using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class LoginDN : MonoBehaviour
{
    // Start is called before the first frame update

    public TMP_InputField edtUser, edtPass;
    public TMP_Text txtError;
    public Selectable first;
    private EventSystem eventSystem;
    public Button btnLogin;
    void Start()
    {
        eventSystem = EventSystem.current;
        first.Select();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Return))
        {
            btnLogin.onClick.Invoke();
        }

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            Selectable next = eventSystem.currentSelectedGameObject
                .GetComponent<Selectable>()
                .FindSelectableOnDown();
            if (next != null) next.Select();
        }
    }
    public void CheckLogin()
    {
        var user = edtUser.text;
        var pass = edtPass.text;

        if(user.Equals("bao") && pass.Equals("123"))
        {
            SceneManager.LoadScene("Scenes1");
        }
        else
        {
            txtError.text = "ERROR!";

        }
    }
}
