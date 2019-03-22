using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public ColorChange rgb;

    private void OnCollisionEnter()
    {
        rgb.c();
    }
}
