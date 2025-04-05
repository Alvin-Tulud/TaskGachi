using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeminiCommunicator : MonoBehaviour
{
    [SerializeField] private stirng gasURL;
    [SerializeField] private string prompt;

    private IEnumerator SendDataToGAS()
    {
        WWWForm form = new WWWForm();
        form.AddField("parameter",prompt);
        UnityWebRequest www = UnityWebRequest.Post(gasURL,form);

        yield return www.SendWebRequest();
        string response = "";

        if(www.result == UnityWebRequest.Results.Success) 
        {
            response = www.downloadHandler.text;
        }
        else
        {
            response = "There was an error!";
        }

        Debug.Log(response);
    }
}
