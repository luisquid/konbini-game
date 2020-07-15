using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClawMovement : MonoBehaviour
{
    public float downSpeed;
    public float movementSpeed;

    Rigidbody clawRb;

    void Start()
    {
        clawRb = GetComponent<Rigidbody>();
    }

    void Update()
    {

        if (Input.GetKey(KeyCode.Space))
        {
            transform.position +=  new Vector3(0.0f,  downSpeed * Time.deltaTime, 0.0f);
            return;
        }

        if(Input.GetKey(KeyCode.LeftAlt))
        {
            transform.position -= new Vector3(0.0f, downSpeed * Time.deltaTime, 0.0f);
            return;
        }

        //transform.position = new Vector3();
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 movement = new Vector3(horizontal * movementSpeed, 0f, vertical * movementSpeed);

        clawRb.MovePosition(transform.position + (movement * Time.deltaTime));
    }
}
