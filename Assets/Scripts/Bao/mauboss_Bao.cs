using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mauboss_Bao : MonoBehaviour
{
    // Start is called before the first frame update
    private float maxHealth = 100;



    void Start()
    {

        maxHealth = 100;


    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            maxHealth = maxHealth - 10;
            Debug.Log("da bi ban trung");
        }
        if (maxHealth <= 0)
        {
            Destroy(gameObject);
        }

    }
}
