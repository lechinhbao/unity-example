using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DieuKhienMenu : MonoBehaviour
{
    public void Playgame()
    {
        SceneManager.LoadScene(2);
    }
    public void BackToLogin()
    {
        SceneManager.LoadScene(0);
    }
}
