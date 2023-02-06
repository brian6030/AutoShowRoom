using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageRotate : MonoBehaviour
{
    public bool isRotate = false;

    [SerializeField] float rotationSpeed;
    float yAngle = 0;

    // Update is called once per frame
    void Update()
    {
        if (!isRotate)
            return;

        yAngle = rotationSpeed *Time.deltaTime;
        gameObject.transform.Rotate(gameObject.transform.localRotation.eulerAngles.x, yAngle, gameObject.transform.localRotation.eulerAngles.z);
    }
}
