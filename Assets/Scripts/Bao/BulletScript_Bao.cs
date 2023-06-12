using System.Collections;
using System.Collections.Generic;
using UnityEngine;

<<<<<<<< HEAD:Assets/Scripts/Nam/BulletScript_Nam.cs
public class BulletScript_Nam : MonoBehaviour
========
public class BulletScript_Bao : MonoBehaviour
>>>>>>>> bao_back:Assets/Scripts/Bao/BulletScript_Bao.cs
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

<<<<<<<< HEAD:Assets/Scripts/Nam/BulletScript_Nam.cs
        transform.Translate((isRight ? Vector3.right : Vector3.left) * Time.deltaTime * 5f );
========
        transform.Translate((isRight ? Vector3.right : Vector3.left) * Time.deltaTime * 30f );

>>>>>>>> bao_back:Assets/Scripts/Bao/BulletScript_Bao.cs

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
