using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarDoorsControl : MonoBehaviour
{
    public bool OpenAll;
    public bool DoorOpenL;
    public bool DoorOpenR;
    public bool EngineBayOpen;
    public bool FrontHoodOpen;
    public bool RearWingOpen;

    bool currentOpen = false;
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (currentOpen != OpenAll) // Becomes true
        {
            DoorOpenL = OpenAll;
            DoorOpenR = OpenAll;
            EngineBayOpen = OpenAll;
            FrontHoodOpen = OpenAll;
            RearWingOpen = OpenAll;

            currentOpen = OpenAll;
        }

        animator.SetBool("DoorOpenL", DoorOpenL);
        animator.SetBool("DoorOpenR", DoorOpenR);
        animator.SetBool("EngineBayOpen", EngineBayOpen);
        animator.SetBool("FrontHoodOpen", FrontHoodOpen);
        animator.SetBool("RearWingOpen", RearWingOpen);
    }
}
