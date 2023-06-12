using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;//Doi man
using static UnityEngine.RuleTile.TilingRuleOutput;
using UnityEditor;
using Unity.VisualScripting;
using TMPro;

public class Player_Nam : MonoBehaviour
{
    private float speed;
    public new Rigidbody2D rigidbody2D;
    private bool isRight = true;
    private int countcoin = 0;
    public TMP_Text txtcoin;
    public AudioSource Soundcoin;
    private Animator animator;
    private int state = 0;
    public float disappearDelay = 0f; // Độ trễ trước khi người chơi tự biến mất
    private bool isDestroyed = false;

    void Start()
    {
        // tốc độ
        speed = 5f;
        rigidbody2D = GetComponent<Rigidbody2D>();
        isRight = true;

        animator = GetComponent<Animator>();
    }

    void Update()
    {
        state = 0;
        if (Input.GetKey(KeyCode.RightArrow))
        {
            // xoay mặt qua phải
            if (isRight == false)
            {
                Vector2 scale = transform.localScale;
                scale.x *= scale.x < 0 ? -1 : 1;
                transform.localScale = scale;
                isRight = true;
            }
            transform.Translate(Vector3.right * speed * Time.deltaTime);
            state = 1;
        }

        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            // xoay mặt qua trái
            if (isRight == true)
            {
                Vector2 scale = transform.localScale;
                scale.x *= scale.x > 0 ? -1 : 1;
                transform.localScale = scale;
                isRight = false;
            }
            transform.Translate(Vector3.left * speed * Time.deltaTime);
            state = 1;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody2D.AddForce(new Vector2(0, 600));
            state = 2;
        }
        animator.SetInteger("state", state);

        //Bắn đạn
        if (Input.GetKeyDown(KeyCode.S))
        {
            var x = transform.position.x + (isRight ? 0.5f : -0.5f);
            var y = transform.position.y;
            var z = transform.position.z;

            GameObject gameObject = (GameObject)Instantiate(
                Resources.Load("Prefabs/bullet_Nam"),
                new Vector3(x, y, z),
                Quaternion.identity
                );
            gameObject.GetComponent<BulletScript_Nam>().setIsRight(isRight);
        }
    }
    //Bắt sựu kiện 2 box collider va chạm nhau
    private void OnCollisionEnter2D(Collision2D collision)
    {
        var name = collision.gameObject.tag;
        if (name.Equals("Floor"))
        {
            state = 2;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "VPG")
        {
            Soundcoin.Play();
            countcoin += 1;
            txtcoin.text = countcoin + "x";
            speed += 2;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Destroy")
        {
            DestroyPlayer();
            Time.timeScale = 0;
        }
    }

    private void DestroyPlayer()
    {
        if (!isDestroyed)
        {
            isDestroyed = true;

            // Tạo một coroutine để tự biến mất sau một khoảng thời gian
            StartCoroutine(DisappearDelay());
        }
    }

    private IEnumerator DisappearDelay()
    {
        // Đợi một khoảng thời gian trước khi người chơi tự biến mất
        yield return new WaitForSeconds(disappearDelay);

        // Người chơi tự biến mất
        gameObject.SetActive(false);
    }

}
