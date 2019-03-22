using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShyDoor : MonoBehaviour
{
    public static int state=10;
    public DoorControl door;

    private void OnBecameVisible()
    {
        state--;
        door.Close();
    }

    private void OnBecameInvisible()
    {
        state++;
        if (state == 10)
        door.Open();
    }
}
