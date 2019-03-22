using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Touch : MonoBehaviour
{
    public string level;

    private void OnCollisionEnter()
    {
        SaveLoad.Save(level);
        SceneManager.LoadScene("Level Change");
    }
}
