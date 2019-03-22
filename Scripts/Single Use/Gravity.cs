using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.iOS;

public class Gravity : MonoBehaviour
{
    private Gyroscope gyro;
    private Rigidbody cube;
    public float speed=1;

    private void Start()
    {
        cube = GetComponent<Rigidbody>();
        gyro = Input.gyro;
        gyro.enabled = true;
    }
    private void FixedUpdate()
    {
        Debug.Log(gyro.gravity);
        Vector3 force = new Vector3(gyro.gravity.x, gyro.gravity.y, -gyro.gravity.z);
        cube.AddForce(force*speed,ForceMode.Acceleration);
        
    }
}
