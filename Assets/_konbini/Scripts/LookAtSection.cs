using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class LookAtSection : MonoBehaviour
{
    public List<GameObject> virtualCameras;

    private int cameraIndex = 0;
    private GameObject currentCamera;

    public void EnableNextCamera()
    {
        currentCamera.SetActive(false);

        cameraIndex++;
        if (cameraIndex > virtualCameras.Count - 1)
            cameraIndex = 0;

        virtualCameras[cameraIndex].SetActive(true);
        currentCamera = virtualCameras[cameraIndex];
    }

    public void EnableCameraAtIndex(int _cameraIndex)
    {
        currentCamera.SetActive(false);
        currentCamera = virtualCameras[_cameraIndex];
        currentCamera.SetActive(true);
    }

    private void Start()
    {
        currentCamera = virtualCameras[cameraIndex];    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            EnableNextCamera();

        if (Input.GetMouseButtonDown(1))
            EnableCameraAtIndex(0);
    }
}
