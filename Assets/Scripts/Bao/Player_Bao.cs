using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;//Doi man
using static UnityEngine.RuleTile.TilingRuleOutput;
using UnityEditor;
using Unity.VisualScripting;
using TMPro;

<<<<<<<< HEAD:Assets/Scripts/Nam/Player_Nam.cs
public class Player_Nam : MonoBehaviour
========
public class Player_Bao : MonoBehaviour
>>>>>>>> bao_back:Assets/Scripts/Bao/Player_Bao.cs
{
    private float speed;
    public new Rigidbody2D rigidbody2D;
    private bool isRight = true;
    public TMP_Text txtcoin;
    public AudioSource Soundcoin;
    private Animator animator;
<<<<<<<< HEAD:Assets/Scripts/Nam/Player_Nam.cs
    private int state = 0;
========
    public float isRunning;
    public bool isJump = false;




>>>>>>>> bao_back:Assets/Scripts/Bao/Player_Bao.cs
    public float disappearDelay = 0f; // Độ trễ trước khi người chơi tự biến mất
    private bool isDestroyed = false;
    public int healt; 

    void Start()
    {
        // tốc độ
        speed = 10f;
        rigidbody2D = GetComponent<Rigidbody2D>();
        isRight = true;

        animator = GetComponent<Animator>();
<<<<<<<< HEAD:Assets/Scripts/Nam/Player_Nam.cs
========
        isRunning = 0;
        healt = 5;
        
>>>>>>>> bao_back:Assets/Scripts/Bao/Player_Bao.cs
    }

    void Update()
    {
<<<<<<<< HEAD:Assets/Scripts/Nam/Player_Nam.cs
        state = 0;
        if (Input.GetKey(KeyCode.RightArrow))
        {
========
        animator.SetBool("run", false);
        animator.SetBool("chayban", false);
        animator.SetBool("dungyenban", false);
        animator.SetBool("nhay", false);
        //isRunning= 0;


        if (Input.GetKey(KeyCode.RightArrow))
        {

            animator.SetBool("run", true); 
            animator.SetBool("chayban", true);
>>>>>>>> bao_back:Assets/Scripts/Bao/Player_Bao.cs
            // xoay mặt qua phải
            if (isRight == false)
            {

               
                Vector2 scale = transform.localScale;
                scale.x *= scale.x < 0 ? -1 : 1;
                transform.localScale = scale;
                isRight = true;
            }
<<<<<<<< HEAD:Assets/Scripts/Nam/Player_Nam.cs
========
          

            // vận tốc
            //rigidbody2D.velocity = new Vector2(speed,0);
            //isRunning = speed;
>>>>>>>> bao_back:Assets/Scripts/Bao/Player_Bao.cs
            transform.Translate(Vector3.right * speed * Time.deltaTime);
            state = 1;
        }

        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            animator.SetBool("run", true);
            animator.SetBool("chayban", true);
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
<<<<<<<< HEAD:Assets/Scripts/Nam/Player_Nam.cs
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody2D.AddForce(new Vector2(0, 600));
            state = 2;
========
        if (isJump = true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                animator.SetBool("nhay", true);
                rigidbody2D.AddForce(new Vector2(0, 400));

            }
            else
            {
                isRunning = 0;
            }
>>>>>>>> bao_back:Assets/Scripts/Bao/Player_Bao.cs
        }
        animator.SetInteger("state", state);

        //Bắn đạn
        if (Input.GetKeyDown(KeyCode.S))
        {
            
            animator.SetBool("dungyenban", true);
            var x = transform.position.x + (isRight ? 0.5f : -0.5f);
            var y = transform.position.y;
            var z = transform.position.z;

            GameObject gameObject = (GameObject)Instantiate(
                Resources.Load("Prefabs/bullet_Nam"),
                new Vector3(x, y, z),
                Quaternion.identity
                );
<<<<<<<< HEAD:Assets/Scripts/Nam/Player_Nam.cs
            gameObject.GetComponent<BulletScript_Nam>().setIsRight(isRight);
========
            gameObject.GetComponent<BulletScript_Bao>().setIsRight(isRight);

>>>>>>>> bao_back:Assets/Scripts/Bao/Player_Bao.cs
        }
    }
    //Bắt sựu kiện 2 box collider va chạm nhau
    private void OnCollisionEnter2D(Collision2D collision)
    {
      
        if(collision.gameObject.tag == "Floor")
        {
<<<<<<<< HEAD:Assets/Scripts/Nam/Player_Nam.cs
            state = 2;
========
            isJump = true;
        }
        if (collision.gameObject.tag == "boss")
        {
            healt--;
            if(healt <= 0 )
            {
                Destroy(gameObject);
            }
>>>>>>>> bao_back:Assets/Scripts/Bao/Player_Bao.cs
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
<<<<<<<< HEAD:Assets/Scripts/Nam/Player_Nam.cs
        if (collision.gameObject.tag == "VPG")
        {
            Soundcoin.Play();
            countcoin += 1;
            txtcoin.text = countcoin + "x";
            speed += 2;
========
       
       if(collision.gameObject.tag == "VPG")
        {
            speed +=2;
>>>>>>>> bao_back:Assets/Scripts/Bao/Player_Bao.cs
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Destroy")
        {
            DestroyPlayer();
            Time.timeScale = 0;
        }
<<<<<<<< HEAD:Assets/Scripts/Nam/Player_Nam.cs
========


>>>>>>>> bao_back:Assets/Scripts/Bao/Player_Bao.cs
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
