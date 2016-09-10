using UnityEngine;
using System.Collections;

public class ARCameraAutomic : MonoBehaviour
{
    // Use this for initialization  
    void Start()
    {
        Vuforia.CameraDevice.Instance.SetFocusMode(Vuforia.CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
    }

    // Update is called once per frame  
    void Update()
    {

            if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)  
        {
            Vuforia.CameraDevice.Instance.SetFocusMode(Vuforia.CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
        }
    }
}