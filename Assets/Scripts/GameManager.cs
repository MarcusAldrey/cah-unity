using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class GameManager : MonoBehaviour
{

    public GameObject canvas;

    [System.Serializable]
    public class AllWhiteCards {
        
        public List<string> answers;
        public static string jsonString;
        public static AllWhiteCards CreateFromJSON(string jsonString) { 
            return JsonUtility.FromJson<AllWhiteCards>(jsonString);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
       
        string jsonString = File.ReadAllText("Assets/Files/white_cards.json");
        AllWhiteCards whiteCards = AllWhiteCards.CreateFromJSON(jsonString);
        /*foreach(string ans in whiteCards.answers){
            print(ans);s
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
