using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClawBehaviour : MonoBehaviour
{
    public Transform leftClaw;
    public Transform rightClaw;
    public Transform backClaw;
    public Transform itemHolder;
    public float rotationSpeed = 5f;

    public void CloseClaw()
    {
        leftClaw.Rotate(Vector3.forward* rotationSpeed, Space.Self);
        rightClaw.Rotate(Vector3.forward * rotationSpeed, Space.Self);
        backClaw.Rotate(Vector3.forward * rotationSpeed, Space.Self);
    }

    public void OpenClaw()
    {
        leftClaw.Rotate(Vector3.forward * -rotationSpeed, Space.Self);
        rightClaw.Rotate(Vector3.forward * -rotationSpeed, Space.Self);
        backClaw.Rotate(Vector3.forward * -rotationSpeed, Space.Self);
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
