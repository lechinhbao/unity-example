using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
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
<<<<<<< HEAD
        transform.Translate((isRight ? Vector3.right : Vector3.left) * Time.deltaTime * 5f );
=======
        transform.Translate((isRight ? Vector3.right : Vector3.left) * Time.deltaTime * 4f );
>>>>>>> 7d6715159febefb34c98eb3d7bccd07fbfa4c165
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
        }
        var name = collision.attachedRigidbody.name;
        Destroy(GameObject.Find(name));
    }
 
}
