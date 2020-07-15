using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public Transform itemHolder;

    private Rigidbody itemRb;
    private bool left, right = false;
    private void Start()
    {
        itemRb = GetComponent<Rigidbody>();
        itemHolder = GameObject.FindGameObjectWithTag("ItemHolder").transform;
    }

    private void Update()
    {
        if (left && right)
        {
            itemRb.useGravity = false;
            transform.position = itemHolder.position;
        }
        else
        {
            itemRb.useGravity = true;
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        print(other.collider.tag);

        if (other.collider.CompareTag("LeftClaw"))
            left = true;
        if (other.collider.CompareTag("RightClaw"))
            right = true;

        if (other.collider.CompareTag("PrizeBin"))
            print("YOU GOT ME");
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.collider.CompareTag("LeftClaw"))
            left = false;
        if (collision.collider.CompareTag("RightClaw"))
            right = false;
    }
}
