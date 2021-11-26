using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour
{
    [Header("Rotations per minute around the arena.")]
    public float RotationsPerMinute = 1.0f;

    void Update()
    {
        // yAngle (in degrees) = 6 * x * deltaTime (seconds).
        // If RotationsPerMinute is equal to 1, yAngle = 360 degrees (6 * 1 * 60).
        var yAngle = 6.0f * RotationsPerMinute * Time.deltaTime;
        var xAngle = 3.0f * RotationsPerMinute * Time.deltaTime;
        var zAngle = 0.30f * RotationsPerMinute * Time.deltaTime;
        transform.Rotate(xAngle, yAngle, zAngle);
        //transform.Rotate(xAngle, 0f, 0f);
    }
}
