using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class GameManager : MonoBehaviour
{
    [System.Serializable]
    public class WhiteCard {
        
        public List<string> answers;
        public static string jsonString;
        public static WhiteCard CreateFromJSON(string jsonString) { 
            return JsonUtility.FromJson<WhiteCard>(jsonString);
        }
    }

    // Start is called before the first frame update
    void Start()
    {   
        string jsonString;
        WhiteCard card1 = new WhiteCard();
        jsonString = File.ReadAllText("Assets/Files/white_cards.json");
        print(jsonString);
        WhiteCard cards = WhiteCard.CreateFromJSON(jsonString);
        foreach(string ans in cards.answers){
            print(ans);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
