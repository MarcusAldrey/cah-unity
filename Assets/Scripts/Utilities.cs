using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Utilities : MonoBehaviour
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
        mouse_in = true;
    }

    public void changeCursorEnter()
    {
        Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
    }

  
    public void FixedUpdate()
    {
        currentSize = new Vector2(gameObject.GetComponent<RectTransform>().rect.width, gameObject.GetComponent<RectTransform>().rect.height);
        
        if (mouse_in)
        {
            if (currentSize.x <= 125)
            {
                gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(currentSize.x + v, currentSize.y + v);
            }
        } 
    }

    public void changeCursorOut()
    {
        Cursor.SetCursor(null, hotSpot, cursorMode);
    }

    public void onHoverExit()
    {
        gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(120, 177);
        mouse_in = false;
    }
}
