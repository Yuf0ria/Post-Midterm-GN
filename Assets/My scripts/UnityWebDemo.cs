using System;
using System.Collections;
using Newtonsoft.Json;
using UnityEngine;
using UnityEngine.Networking;

public class UnityWebDemo : MonoBehaviour
{
    public const string BASE_URL ="https://dogapi.dog/api/v2/";
    // public const Breeds = "Breeds";

    public IEnumerator Get<T>(string route, Action<T> OnSuccess, Action<string> OnError)
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(BASE_URL + route))
        {
            yield return webRequest.SendWebRequest();

            if (webRequest.result == UnityWebRequest.Result.Success)
            {
                Debug.Log(webRequest.downloadHandler.text);
                try
                {
                    var objdata = JsonConvert.DeserializeObject<T>(webRequest.downloadHandler.text);
                }
                catch (Exception e)
                {
                    Debug.LogError(e.ToString());
                }
            }
            else
            {
                Debug.LogError($"Unsuccessful Request: {BASE_URL + route}");
                OnError?.Invoke(webRequest.error);
            }

        }
    }
}
