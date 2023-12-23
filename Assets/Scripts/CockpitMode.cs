using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CockpitMode : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform PlayerTransform;
    public Transform PlayerLastTransform;
    public Transform CockpitTransform;

    [SerializeField] bool IsCockpitView = false;

    StarterAssets.FirstPersonController firstPersonController;
    Transform playerCameraRoot;
    [SerializeField] float camHeightOutsideCockpit = 1.6f;
    [SerializeField] float camHeightInsideCockpit = 0.6f;

    void Start()
    {
        playerCameraRoot = PlayerTransform.Find("PlayerCameraRoot");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Spacebar was pressed
            if (IsCockpitView)
            {
                IsCockpitView = false;
                PlayerTransform.GetComponent<CharacterController>().enabled = false;

                PlayerTransform.position = PlayerLastTransform.position;
                PlayerLastTransform.rotation = PlayerLastTransform.rotation;
                playerCameraRoot.position = new Vector3(playerCameraRoot.position.x, camHeightOutsideCockpit, playerCameraRoot.position.z);

                PlayerTransform.GetComponent<CharacterController>().enabled = true;
            }
            else 
            {
                IsCockpitView = true;
                PlayerTransform.GetComponent<CharacterController>().enabled = false;

                PlayerLastTransform.position = PlayerTransform.position;
                PlayerLastTransform.rotation = PlayerTransform.rotation;

                PlayerTransform.position = CockpitTransform.position;
                PlayerTransform.rotation = CockpitTransform.rotation;

                playerCameraRoot.position = new Vector3(playerCameraRoot.position.x, camHeightInsideCockpit, playerCameraRoot.position.z);
            }
        }
    }
}
