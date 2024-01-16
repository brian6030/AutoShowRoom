using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelSliding : MonoBehaviour
{
    public Vector2 SlidingDirection; // Relative movement (percentage of screen width and height)
    public KeyCode keyToPress;
    public bool IsShown = false;

    Vector2 panelPosition;
    RectTransform panelRectTransform;


    // Start is called before the first frame update
    void Start()
    {
        panelRectTransform = GetComponent<RectTransform>();
        panelPosition = panelRectTransform.anchoredPosition;

        if (!IsShown) 
        {
            HidePanel();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyToPress))
        {
            if (IsShown) // Hide panel
            {
                HidePanel();                
            }
            else // Show panel
            {
                ShowPanel();
            }
        }
    }

    void HidePanel() 
    {
        panelRectTransform.anchoredPosition = panelPosition + SlidingDirection;

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        IsShown = false;
    }

    void ShowPanel() 
    {
        panelRectTransform.anchoredPosition = panelPosition;

        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

        IsShown = true;
    }
}
