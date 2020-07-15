using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    public List<GameObject> cameraList;

    private int cameraIndex = 0;
    private GameObject currentCamera;
    
    public void MoveNextCamera()
    {
        currentCamera.SetActive(false);

        cameraIndex++;
        if (cameraIndex > cameraList.Count - 1)
            cameraIndex = 0;

        cameraList[cameraIndex].SetActive(true);
        currentCamera = cameraList[cameraIndex];
    }

    public void MovePreviousCamera()
    {
        currentCamera.SetActive(false);

        cameraIndex--;
        if (cameraIndex < 0)
            cameraIndex = cameraList.Count - 1;

        cameraList[cameraIndex].SetActive(true);
        currentCamera = cameraList[cameraIndex];
    }

    // Start is called before the first frame update
    void Start()
    {
        currentCamera = cameraList[cameraIndex];
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
            MoveNextCamera();

        if (Input.GetKeyDown(KeyCode.Q))
            MovePreviousCamera();
    }
}
