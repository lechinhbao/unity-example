using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomQuai : MonoBehaviour
{
    private int count = 3;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
        if (count-- > 0)
        {
            float position = Random.Range(-5f, 6f);
            GameObject qv = (GameObject)Instantiate(Resources.Load("Prefabs/quaivat1"), new Vector3(position, -3.47f, 0), Quaternion.identity);
            qv.GetComponent<quaivat1>().SetStart(position - 5);
            qv.GetComponent<quaivat1>().SetEnd(position + 6);
            qv.GetComponent<quaivat1>().SetPlayer(player);
        }
    }
}
