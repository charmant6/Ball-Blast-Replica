using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelMove : MonoBehaviour
{ // deðiþkenleri küçük yaz
    public Transform wheelRight, wheelLeft;
    public float rotationSpeed = 200f;

    public void WheelRightRotation()
    {
        wheelRight.Rotate(0f, 0f, -rotationSpeed * Time.deltaTime);
        wheelLeft.Rotate(0f, 0f, -rotationSpeed * Time.deltaTime);


    }
    public void WheelLeftRotation()
    {
        wheelRight.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);
        wheelLeft.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);


    }
    public void StopWheelRotation()
    {
        wheelRight.Rotate(0f, 0f, 0f);
        wheelLeft.Rotate(0f, 0f, 0f);


    }
}
