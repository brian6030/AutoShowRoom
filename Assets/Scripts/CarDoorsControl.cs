using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarDoorsControl : MonoBehaviour
{
    public bool DoorOpenL;
    public bool DoorOpenR;
    public bool EngineBayOpen;
    public bool FrontHoodOpen;

    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        /*
        animator.SetBool("DoorOpenL", DoorOpenL);
        animator.SetBool("DoorOpenR", DoorOpenR);
        animator.SetBool("EngineBayOpen", EngineBayOpen);
        animator.SetBool("FrontHoodOpen", FrontHoodOpen);
        */
    }
}
