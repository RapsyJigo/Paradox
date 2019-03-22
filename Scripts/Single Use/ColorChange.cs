using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public Material mat;
    private Color rgb;

    private void Start()
    {
        mat.color = rgb;
    }

    public void c()
    {

        rgb.b = Random.value;
        rgb.g = Random.value;
        rgb.r = Random.value;
        Debug.Log(rgb);
        mat.color = rgb;
    }
}
