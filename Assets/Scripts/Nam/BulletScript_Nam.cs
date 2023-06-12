using System.Collections;
using System.Collections.Generic;
using UnityEngine;

<<<<<<<< HEAD:Assets/Scripts/Bao/BulletScript_Bao.cs
public class BulletScript_Bao : MonoBehaviour
========
public class BulletScript_Nam : MonoBehaviour
>>>>>>>> nam:Assets/Scripts/Nam/BulletScript_Nam.cs
{
    private bool isRight;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        //Di chuyển đạn

<<<<<<<< HEAD:Assets/Scripts/Bao/BulletScript_Bao.cs
        transform.Translate((isRight ? Vector3.right : Vector3.left) * Time.deltaTime * 30f );

========
        transform.Translate((isRight ? Vector3.right : Vector3.left) * Time.deltaTime * 5f );
>>>>>>>> nam:Assets/Scripts/Nam/BulletScript_Nam.cs

    }
    public void setIsRight(bool isRight)
    {
        this.isRight = isRight;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Destroy")
        {
            //Kill đạn
            Destroy(gameObject);
            var name_quai = collision.attachedRigidbody.name;
            Destroy(GameObject.Find(name_quai));
        }
        
    }
 
}
