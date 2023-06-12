using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

<<<<<<<< HEAD:Assets/Scripts/Bao/Monster_bao.cs
public class Monster_Bao : MonoBehaviour
========
public class BtnDirect_Login_Register : MonoBehaviour
>>>>>>>> sy:Assets/Scripts/ButtonDirect/BtnDirect_Login_Register.cs
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
