using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelSliding : MonoBehaviour
{
    public Vector2 SlidingDirection;
    public KeyCode keyToPress;
    public bool IsShown = false;

    Transform originalTransform;

    // Start is called before the first frame update
    void Start()
    {
        originalTransform = transform;

        if (!IsShown) 
        {
            transform.position = originalTransform.position + new Vector3(SlidingDirection.x, SlidingDirection.y, 0f);

            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyToPress))
        {
            if (IsShown) // Hide panel
            {
                transform.position = originalTransform.position + new Vector3(SlidingDirection.x, SlidingDirection.y, 0f);

                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;

                IsShown = false;
            }
            else // Show panel
            {
                transform.position = originalTransform.position - new Vector3(SlidingDirection.x, SlidingDirection.y, 0f);
                
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;

                IsShown = true;
            }
        }
    }
}
