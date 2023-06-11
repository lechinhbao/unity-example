using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnRegister : MonoBehaviour
{
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
        Debug.Log("run");
    }

    private void sendRequest()
    {
    //     string jsonStringRequest = JsonConvert.SerializeObject(userModel);

    //     var request = new UnityWebRequest("https://hoccungminh.dinhnt.com/fpt/login", "POST");
    //     byte[] bodyRaw = Encoding.UTF8.GetBytes(jsonStringRequest);
    //     request.uploadHandler = new UploadHandlerRaw(bodyRaw);
    //     request.downloadHandler = new DownloadHandlerBuffer();
    //     request.SetRequestHeader("Content-Type", "application/json");
    //     yield return request.SendWebRequest();

    //     if (request.result != UnityWebRequest.Result.Success)
    //     {
    //         Debug.Log(request.error);
    //     }
    //     else
    //     {
    //         var jsonString = request.downloadHandler.text.ToString();
    //         MessageModel message = JsonConvert.DeserializeObject<MessageModel>(jsonString);
    //     }
    }
}
