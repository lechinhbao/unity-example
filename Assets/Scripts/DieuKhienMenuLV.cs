using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DieuKhienMenuLV : MonoBehaviour
{
    public void PlayGame1()
    {
        SceneManager.LoadScene(1);
    }
    public void PlayGame2()
    {
        SceneManager.LoadScene(4);
    }
    public void PlayGame3()
    {
        SceneManager.LoadScene(5);
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene(1);
    }
}
