using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Movement : MonoBehaviour
{
    public JoystickControl virtualjoystick;
    public float speed;
    private Vector3 dir;

	void FixedUpdate ()
    {
        dir.x = virtualjoystick.Horizontal();
        dir.z = virtualjoystick.Vertical();
       
        transform.Translate(virtualjoystick.Horizontal() * Time.deltaTime*speed, 0f, virtualjoystick.Vertical() * Time.deltaTime*speed);

	}
}
