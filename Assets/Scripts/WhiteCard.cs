using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteCard : MonoBehaviour
{
    public GameObject whiteCard;
    public GameObject blackCard;

    public GameObject questionArea;
    public GameObject playerArea;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnClick()
    {
        for (int i = 0; i < 5; i++)
        {
            GameObject whitec = Instantiate(whiteCard, new Vector3(0, 0, 0), Quaternion.identity);
            whitec.transform.SetParent(playerArea.transform, false);

            GameObject blackc = Instantiate(blackCard, new Vector3(0, 0, 0), Quaternion.identity);
            blackc.transform.SetParent(questionArea.transform, false);
        }
    }
}
