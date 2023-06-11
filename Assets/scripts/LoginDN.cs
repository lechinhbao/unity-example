using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;
using System.Text;
using UnityEngine.Networking;
using Newtonsoft.Json;







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

        UserModel userModel = new UserModel(user,pass);
        StartCoroutine(smsLogin(userModel));
        smsLogin(userModel);

        //if(user.Equals("bao") && pass.Equals("123"))
        //{
           //SceneManager.LoadScene("Screen 0");
       // }
        //else
       // {
        //    txtError.text = "ERROR!";

       // }
    }

    IEnumerator smsLogin(UserModel userModel)
    {
        //…
        string jsonStringRequest = JsonConvert.SerializeObject(userModel);

       // var request = new UnityWebRequest("https://hoccungminh.dinhnt.com/fpt/save-score", "POST");
        var request = new UnityWebRequest("https://rich-plum-pocket.cyclic.app/api/mob104/user/login", "POST");
        byte[] bodyRaw = Encoding.UTF8.GetBytes(jsonStringRequest);
        request.uploadHandler = new UploadHandlerRaw(bodyRaw);
        request.downloadHandler = new DownloadHandlerBuffer();
        request.SetRequestHeader("Content-Type", "application/json");
        yield return request.SendWebRequest();

        if (request.result != UnityWebRequest.Result.Success)
        {
            Debug.Log("request failed " + request.error);
        }
        else
        {
            Debug.Log("run");
            var jsonString = request.downloadHandler.text.ToString();
            LoginResponModel loginResponModel = JsonConvert.DeserializeObject<LoginResponModel>(jsonString);
            Debug.Log(loginResponModel.age);
            SceneManager.LoadScene("Screen 1");
            //  LoginResponModel loginResponModel = JsonConvert.DeserializeObject<LoginResponModel>(jsonString);
            // Debug.Log(loginResponModel);
            //  if (loginResponModel.id != null)
            //    {
            //       SceneManager.LoadScene(1);
            //   }
            //  else
            //  {
            //     txtError.text = "Login Failed";

            // }

        }
    }

}
