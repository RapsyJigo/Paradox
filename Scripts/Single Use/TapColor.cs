using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapColor : MonoBehaviour
{
    public ColorChange rgb;
    private void OnMouseUpAsButton()
    {
        rgb.c();
    }
}
