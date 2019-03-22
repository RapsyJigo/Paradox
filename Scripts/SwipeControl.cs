using UnityEngine;
using UnityEngine.EventSystems;

public class SwipeControl : MonoBehaviour , IPointerDownHandler, IDragHandler
{
    public GameObject player;
    public GameObject camControl;
    public GameObject Dummy;

    private Vector2 initialPos;

    public float speed = 0.5f;

    public void OnPointerDown (PointerEventData ped)
    {
        initialPos = ped.position;
        OnDrag(ped);
    }
    
    public void OnDrag (PointerEventData ped)
    {
        Dummy.transform.eulerAngles = camControl.transform.eulerAngles;
        Dummy.transform.Rotate((initialPos.y - ped.position.y) * -1 * Time.deltaTime * speed, 0f, 0f);
        if ((Dummy.transform.eulerAngles.x >= 0 && Dummy.transform.eulerAngles.x <= 80) || (Dummy.transform.eulerAngles.x >= 280 && Dummy.transform.eulerAngles.x <= 360))
            camControl.transform.Rotate((initialPos.y - ped.position.y) * -1 * Time.deltaTime * speed, 0f, 0f);

        else if (Dummy.transform.eulerAngles.x < 280 && Dummy.transform.eulerAngles.x > 270)
            Dummy.transform.eulerAngles = new Vector3(280, 0f, 0f);
        else
            Dummy.transform.eulerAngles = new Vector3(80, 0f, 0f);


        player.transform.Rotate(0f, (initialPos.x - ped.position.x ) * Time.deltaTime * speed, 0f);


        initialPos = ped.position;
    }


}
