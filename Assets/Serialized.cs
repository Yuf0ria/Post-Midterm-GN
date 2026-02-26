using System;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;

public class Serialized : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        var data = new PlayerData()
        {
            PlayerName = "Jojo",
            PlayerExp = 136,
            Inventory = new Dictionary<string, int>()
            {
                {"Sword", 1},
                {"Axe", 1},
            },
            Tester = "I am a tester"
        };
        

        
        var receivedData = "{\"PlayerName\":\"Jojo\",\"PlayerExp\":100}";
        var recieved = JsonConvert.DeserializeObject<PlayerData>(receivedData);
        
        Debug.Log($"Name: {recieved.PlayerName}, Experience: {recieved.PlayerExp}");
        Debug.Log(JsonConvert.SerializeObject(data));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    [Serializable]
    public class PlayerData
    {
        //JsonProperty: can rename stuff
        //newtonsoft Json: Json on steroids
        //APIs in selection: Postman or <--This one
        [JsonProperty("player_name")]
        public string PlayerName { get; set; }
        [JsonProperty("exp")]
        public int PlayerExp { get; set; }
        public Dictionary<string, int> Inventory { get; set; }
        [JsonIgnore]
        public string Tester { get; set; }
    }
}
