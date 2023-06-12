using System.Collections;
using System.Collections.Generic;
using UnityEngine;

<<<<<<<< HEAD:Assets/Scripts/Bao/CameraScripts_Bao.cs
public class CameraScripts_Bao : MonoBehaviour
========
public class CameraScripts_Nam : MonoBehaviour
>>>>>>>> nam:Assets/Scripts/Nam/CameraScripts_Nam.cs
{
    public float left, right;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        //Lấy vị trí trục x của player
        var playerX = player.transform.position.x;
        var playerY = player.transform.position.y;

        //Lấy vị trí trục x của cam
        var cameraX = transform.position.x;
        var cameraY = transform.position.y;

        if (playerX > left && playerX < right)
        {
            cameraX = playerX;
        }
        else
        {
            if (cameraX < left) cameraX = left;
            if (cameraX > right) cameraX = right;
        }
        if (playerY > 0)
        {
            cameraY = playerY;
        }
        else
        {
            cameraY = 0;
        }


        transform.position = new Vector3(cameraX, cameraY, -10);
    }
}

