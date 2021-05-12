using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AnswerCard : MonoBehaviour
{

    public List<string> answers;

    public GameObject TMB_Object;

    private TMP_Text text;

    private int owner_player_id;

    // Start is called before the first frame update
    void Start()
    {
        text = TMB_Object.GetComponent<TextMeshProUGUI>();
        string text_from_database = "Preciso comprar * e *.";
        answers.Add("Banana");
        answers.Add("Uva");

        string formated_answer = formatAnswer(text_from_database, answers.ToArray());
        text.text = formated_answer;
    }

    private string formatAnswer(string text, string[] ans)
    {
        int count = 0;
        text = text.Replace("*", "{}");
        Debug.Log(text);
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == '{')
            {
                text = text.Insert(i+1, count.ToString("D1"));
                count++;
            }
        }
        text = string.Format(text, ans);
        return text;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
