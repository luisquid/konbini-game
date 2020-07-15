using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClawBehaviour : MonoBehaviour
{
    public Transform leftClaw;
    public Transform rightClaw;
    public Transform itemHolder;
    public float rotationSpeed = 5f;

    public void CloseClaw()
    {
        leftClaw.Rotate(Vector3.forward * rotationSpeed);
        rightClaw.Rotate(Vector3.back * rotationSpeed);
    }

    public void OpenClaw()
    {
        leftClaw.Rotate(Vector3.forward * -rotationSpeed);
        rightClaw.Rotate(Vector3.back * -rotationSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.X))
            CloseClaw();
        if (Input.GetKey(KeyCode.Z))
            OpenClaw();
    }
}
