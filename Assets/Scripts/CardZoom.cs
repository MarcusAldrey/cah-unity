using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardZoom : MonoBehaviour
{
    public GameObject canvas;
    public GameObject playerArea;

    private float v = 3F;

    private Vector2 currentSize;

    public bool mouse_in;

    public Texture2D cursorTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;

    public void Awake()
    {
        canvas = GameObject.Find("Main Canvas");
        playerArea = GameObject.Find("PlayerArea");
    }

    public void onHoverEnter()
    {
        Destroy(playerArea.GetComponent<GridLayoutGroup>());
        Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
        mouse_in = true;
    }

  
    public void FixedUpdate()
    {
        currentSize = new Vector2(gameObject.GetComponent<RectTransform>().rect.width, gameObject.GetComponent<RectTransform>().rect.height);
        
        if (mouse_in)
        {
            if (currentSize.x <= 140)
            {
                gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(currentSize.x + v, currentSize.y + v);
            }
        } 
    }

    public void onHoverExit()
    {
        gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(120, 177);
        mouse_in = false;
        Cursor.SetCursor(null, hotSpot, cursorMode);
    }
}
