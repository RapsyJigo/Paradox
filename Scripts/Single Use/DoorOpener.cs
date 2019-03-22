using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpener : MonoBehaviour
{

    public DoorControl door;

    private void OnCollisionEnter()
    {
        door.Open();
        Destroy(gameObject);
    }
}
