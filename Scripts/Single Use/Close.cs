using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Close : MonoBehaviour
{
    public DoorControl door;

    private void OnCollisionEnter()
    {
        door.Close();
    }
}
