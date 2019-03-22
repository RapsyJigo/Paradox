using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextChanger : MonoBehaviour
{
    public Texture[] texture;
    public Material mat;

    private int difficulty;
    public float seconds;

    private void Start()
    {
        difficulty = texture.Length-1;
        mat.mainTexture = texture[difficulty];
        StartCoroutine(countdown());
    }
    private void OnBecameVisible()
    {
        mat.mainTexture = texture[difficulty];
    }

    IEnumerator countdown()
    {
        while (difficulty > 0)
        {
            Debug.Log(difficulty);

            yield return new WaitForSeconds(seconds);
                difficulty--;
        }
    }
}
