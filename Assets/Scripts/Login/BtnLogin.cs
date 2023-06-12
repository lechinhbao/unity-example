using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using UnityEngine;
using UnityEngine.UI;

public class BtnLogin : MonoBehaviour
{
    [SerializeField] private InputField inputEmail;
    [SerializeField] private InputField inputPassword;
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
                UserResponse userResponse = JsonConvert.DeserializeObject<UserResponse>(responseData);
                // UserResponse userResponse = JsonUtility.FromJson<UserResponse>(responseData);
                Debug.Log("name: " + userResponse.name);
            }
        }
    }
}
