using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open : MonoBehaviour
{
    public DoorControl door;

    private void Start()
    {
        door.Open();   
    }
}
