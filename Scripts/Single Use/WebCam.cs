using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebCam : MonoBehaviour
{
    private static WebCamTexture cam;
    public GameObject display;
    public DoorControl door;

    private Color[] pixels;
    private int average;


    private void Start()
    {
        cam = new WebCamTexture();
        cam.Play();
        display.GetComponent<Renderer>().material.mainTexture = cam;
        StartCoroutine(check());
    }

    IEnumerator check ()
    {
        while (average < 7500)
        {
            average = 0;
            pixels = cam.GetPixels(cam.width / 2 - 50, cam.height / 2 - 50, 100, 100);
            for (int i = 0; i < pixels.Length; i++)
            {
                if (pixels[i].b > 0.7 && pixels[i].r < 0.65 && pixels[i].g < 0.65)
                {
                    average++;
                }
            }
            yield return new WaitForSeconds(1);
            Debug.Log(average);
        }
        door.Open();
    }
}
