using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BtnLogin : MonoBehaviour
{
    [SerializeField] private InputField inputEmail;
    [SerializeField] private InputField inputPassword;
    [SerializeField] private Text txtNotification;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    public void login()
    {
        string email = inputEmail.text;
        string password = inputPassword.text;

        User user = new User(email, password);
        sendUserAsync(user);
    }

    async private void sendUserAsync(User user)
    {
        var content = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");
        using (var httpClient = new HttpClient())
        {
            using (var response = await httpClient.PostAsync("https://rich-plum-pocket.cyclic.app/api/mob104/user/login", content))
            {
                string responseData = await response.Content.ReadAsStringAsync();
                try
                {
                    UserResponse userResponse = JsonConvert.DeserializeObject<UserResponse>(responseData);
                    if (userResponse.status == 200)
                    {
                        UserResponse.setInstance(userResponse);
                        txtNotification.text = "Login successfully wait for minutes...";
                        Invoke("loadScene", 3);
                        Debug.Log("Doned");
                    }
                    else
                    {
                        txtNotification.text = "Login failed";
                        Debug.Log("Failed");
                    }
                }
                catch (System.Exception)
                {
                    txtNotification.text = "Login failed";
                    Debug.Log("Failed");
                }
            }
        }
    }

    private void loadScene()
    {
        SceneManager.LoadScene("Screen 2");
    }
}
