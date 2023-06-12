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
            // float position = Random.Range(-5f, 0f);
            // GameObject qv = (GameObject)Instantiate(Resources.Load("Prefabs/quaivat2"), new Vector3(position, -2.88f, -5.95f), Quaternion.identity);
            // qv.GetComponent<quaivat1>().SetStart(position - 5);
            // qv.GetComponent<quaivat1>().SetEnd(position + 0);
            // qv.GetComponent<quaivat1>().SetPlayer(player);
        }
    }
}
