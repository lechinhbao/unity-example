using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnDirect_Login_Register : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void directLogin(){
        SceneManager.LoadScene("Login");
    }


    public void directRegister(){
        SceneManager.LoadScene("Register");
    }
}
