using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    public Camera cam;

    private float xRot = 0f;

    public float xSens = 18f;
    public float ySens = 18f;
    
    public void ProccessLook(Vector2 input)
    {
        float mouseX = input.x;
        float mouseY = input.y;

        xRot -= mouseY * ySens * Time.deltaTime;
        xRot = Mathf.Clamp(xRot, -90f, 90f);

        cam.transform.localRotation = Quaternion.Euler(xRot, 0f, 0f);

        transform.Rotate(Vector3.up * (mouseX * Time.deltaTime) * xSens);
    }
}
