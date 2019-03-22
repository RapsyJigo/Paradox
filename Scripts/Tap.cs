using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tap : MonoBehaviour
{
    public string level;

    private void OnMouseUpAsButton()
    {
        SaveLoad.Save(level);
        SceneManager.LoadScene("Level Change");
    }
}

