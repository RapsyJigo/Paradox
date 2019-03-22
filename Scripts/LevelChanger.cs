using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{
    private void Start()
    {
        SaveLoad.Load();
        SceneManager.LoadScene(SaveLoad.Level);
    }
}
