using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuUIController : MonoBehaviour
{
    public LookAtSection cameraB;

    public void EnableCamera(int _cameraIndex)
    {
        cameraB.EnableCameraAtIndex(_cameraIndex);
    }
}
