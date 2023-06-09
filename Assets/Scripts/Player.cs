using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;//Doi man
using static UnityEngine.RuleTile.TilingRuleOutput;
using UnityEditor;
using Unity.VisualScripting;

public class Player : MonoBehaviour
{
    private float speed;
    public new Rigidbody2D rigidbody2D;
    private bool isRight = true;
    //animator
    private Animator animator;
    public float isRunning;
    public bool isJump;
    void Start()
    {
        // tốc độ
        speed = 5f;
        rigidbody2D = GetComponent<Rigidbody2D>();
        isRight = true;

        animator = GetComponent<Animator>();
        isRunning = 0;
        isJump = false;
    }

    void Update()
    {
        animator.SetFloat("IsRunning", isRunning);
        animator.SetBool("IsJump", isJump);
        //isRunning= 0;


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

            // vận tốc
            //rigidbody2D.velocity = new Vector2(speed,0);
            //isRunning = speed;
            transform.Translate(Vector3.right * speed * Time.deltaTime);
            isRunning = 100;
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
            // vận tốc
            //rigidbody2D.velocity = new Vector2(-speed,0);
            //isRunning = speed;
            transform.Translate(Vector3.left * speed * Time.deltaTime);
            isRunning = 100;
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody2D.AddForce(new Vector2(0, 400));
            isJump = true;
            isRunning = 0;

        }
        else
        {
            isRunning = 0;
        }

        //Bắn đạn
        if (Input.GetKeyDown(KeyCode.S))
        {
            var x = transform.position.x + (isRight ? 0.5f : -0.5f);
            var y = transform.position.y;
            var z = transform.position.z;

            GameObject gameObject = (GameObject)Instantiate(
                Resources.Load("Prefabs/bullet"),
                new Vector3(x, y, z),
                Quaternion.identity
                );
            gameObject.GetComponent<BulletScript>().setIsRight(isRight);

        }

    }
    //Bắt sựu kiện 2 box collider va chạm nhau
    private void OnCollisionEnter2D(Collision2D collision)
    {
        var name = collision.gameObject.tag;
        if (name.Equals("Floor"))
        {
            isJump = false;
        }

    }
}
