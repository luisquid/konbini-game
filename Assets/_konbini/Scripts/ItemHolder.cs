using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemHolder : MonoBehaviour
{
    public GameObject heldItem;
    public bool isHoldingItem = false;

    public void DropItem()
    {
        heldItem.GetComponent<Rigidbody>().useGravity = true;
        heldItem = null;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
            DropItem();
        if(heldItem != null)
            heldItem.transform.position = transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Item") && !isHoldingItem)
        {
            print("I AM AN ITEM");
            isHoldingItem = true;
            heldItem = other.gameObject;
            heldItem.GetComponent<Rigidbody>().useGravity = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        isHoldingItem = false;
    }
}
