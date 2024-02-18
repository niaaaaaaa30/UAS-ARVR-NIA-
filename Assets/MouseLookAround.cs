using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLookAround : MonoBehaviour
{
    float rotationX = 0f;
    float rotationY = 0f;

    public float sensitivity = 5f;

    void Update()
    {
        rotationY += Input.GetAxis("Mouse X") * sensitivity;
        rotationX -= Input.GetAxis("Mouse Y") * sensitivity; // Menggunakan pengurangan (*) bukan tanda kurang (-)
        rotationX = Mathf.Clamp(rotationX, -90f, 90f); // Memastikan rotasi X tetap dalam rentang -90° hingga 90°
        transform.localEulerAngles = new Vector3(rotationX, rotationY, 0f);
    }
}
