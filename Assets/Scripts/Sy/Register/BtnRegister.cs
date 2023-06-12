using System.Collections;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class BtnRegister : MonoBehaviour
{
    [SerializeField] private InputField inputEmail;
    [SerializeField] private InputField inputPassword;
    [SerializeField] private InputField inputName;
    [SerializeField] private InputField inputAge;
    [SerializeField] private Text txtNotification;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void register()
    {
        string email = inputEmail.text;
        string password = inputPassword.text;
        string name = inputName.text;
        int age = System.Convert.ToInt32(inputAge.text);

        User user = new User(email, password, name, age);
        sendUserAsync(user);
    }

    IEnumerator Send()
    {
        UnityWebRequest www = UnityWebRequest.Get("https://rich-plum-pocket.cyclic.app/api/mob104/user/get-all-user-score");
        yield return www.SendWebRequest();
        if (www.result != UnityWebRequest.Result.Success)
        {
            Debug.Log(www.error);
        }
        else
        {
            Debug.Log(www.downloadHandler.text);
        }
    }

    async void sendUserAsync(User user)
    {
        var content = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");
        using (var httpClient = new HttpClient())
        {
            using (var response = await httpClient.PostAsync("https://rich-plum-pocket.cyclic.app/api/mob104/user/register", content))
            {
                string responseData = await response.Content.ReadAsStringAsync();
                try
                {
                    UserResponse userResponse = JsonConvert.DeserializeObject<UserResponse>(responseData);
                    if (userResponse.status == 200)
                    {
                        UserResponse.setInstance(userResponse);
                        txtNotification.text = "Register successfully";
                        Debug.Log("Doned");
                    }
                    else
                    {
                        txtNotification.text = "Register failed";
                        Debug.Log("Failed");
                    }
                }
                catch (System.Exception)
                {
                    txtNotification.text = "Register failed";
                    Debug.Log("Failed");
                }
            }
        }
    }
}
