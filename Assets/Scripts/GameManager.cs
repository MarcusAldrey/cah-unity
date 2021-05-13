using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using TMPro;

public class GameManager : MonoBehaviour
{

    public GameObject canvas;

    public WhiteCard whiteCard;
    public GameObject blackCard;

    public GameObject questionArea;
    public GameObject playerArea;

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
        AllWhiteCards allWhiteCards = AllWhiteCards.CreateFromJSON(jsonString);
        
        
        for (int i = 0; i < 5; i++)
        {
            WhiteCard whitec = Instantiate(whiteCard, new Vector3(0, 0, 0), Quaternion.identity);
            
            int index = Random.Range(0, allWhiteCards.answers.Count);
            whitec.TMP_object.GetComponent<TextMeshProUGUI>().text = allWhiteCards.answers[index];
            whitec.index = index;
            allWhiteCards.answers.RemoveAt(index);

            Debug.Log(allWhiteCards.answers.Count);

            whitec.transform.SetParent(playerArea.transform, false);

            /*GameObject blackc = Instantiate(blackCard, new Vector3(0, 0, 0), Quaternion.identity);
            blackc.transform.SetParent(questionArea.transform, false);*/
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
