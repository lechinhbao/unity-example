using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class boss_Bao : MonoBehaviour
{
    public float start, end;
    private bool isRight;
    private Animator animator;
    private int speed = 10;

    void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("bossdanh", true);
    }

    void Update()
    {
        var positionEnemy = transform.position.x;
        if (positionEnemy < start)
        {
            isRight = true;
            speed = 10; // Đặt lại tốc độ về bình thường khi boss ở vị trí ban đầu
        }
        if (positionEnemy > end)
        {
            isRight = false;
            speed = 10; // Đặt lại tốc độ về bình thường khi boss vượt qua giới hạn
        }

        Vector2 scale = transform.localScale;
        if (isRight)
        {
            scale.x = 1;
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        else
        {
            scale.x = -1;
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        transform.localScale = scale;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            animator.SetBool("bossdanh", false);
            speed += 10;
        }
        
    }
}
