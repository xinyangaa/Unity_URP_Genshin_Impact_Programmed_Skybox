using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleCameraRotate : MonoBehaviour
{
    public float sensitivity = 0.5f;
    private float rotationX = 0.0f;
    private float rotationY = 0.0f;

    void Start()
    {
        Vector3 rot = transform.localRotation.eulerAngles;
        rotationX = rot.x;
        rotationY = rot.y;
    }

    void Update()
    {
//           Debug.Log("Update called");
       // #if UNITY_STANDALONE || UNITY_WEBGL
            if (Input.GetMouseButton(0))
            {
                  Debug.Log("Mouse button down"); 
                rotationY += Input.GetAxis("Mouse X") * sensitivity;
                rotationX -= Input.GetAxis("Mouse Y") * sensitivity;

                rotationX = Mathf.Clamp(rotationX, -90, 90);

                Quaternion localRotation = Quaternion.Euler(rotationX, rotationY, 0.0f);
                transform.rotation = localRotation;
            }
        /*
        #elif UNITY_IOS || UNITY_ANDROID
            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);
                if (touch.phase == TouchPhase.Moved)
                {
                    rotationY += touch.deltaPosition.x * sensitivity;
                    rotationX -= touch.deltaPosition.y * sensitivity;

                    rotationX = Mathf.Clamp(rotationX, -90, 90);

                    Quaternion localRotation = Quaternion.Euler(rotationX, rotationY, 0.0f);
                    transform.rotation = localRotation;
                }
            }
        #endif
        */
    }
}
