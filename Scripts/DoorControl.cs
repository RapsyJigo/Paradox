using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorControl : MonoBehaviour
{
    private Animator anim;
    public Material plane;

    private void Start()
    {
        plane.color = Color.red;
        anim = GetComponent<Animator>();
    }

    public void Open ()
    {
        plane.color = Color.green;
        anim.SetBool("State", true);
    }

    public void Close ()
    {
       plane.color = Color.red;
       anim.SetBool("State", false);
    }

}
