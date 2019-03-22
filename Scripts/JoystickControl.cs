using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class JoystickControl : MonoBehaviour , IDragHandler , IPointerDownHandler, IPointerUpHandler
{ 

    private Image bimg;
    private Image fimg;
    private Vector3 input;


	void Start ()
    {
        bimg = GetComponent<Image>();
        fimg = transform.GetChild(0).GetComponent<Image>();
	}

    public virtual void OnPointerDown (PointerEventData ped)
    {
        OnDrag(ped);
    }
    public virtual void OnPointerUp (PointerEventData ped)
    {
        input = Vector3.zero;
        fimg.rectTransform.anchoredPosition = input;
    }
    public virtual void OnDrag (PointerEventData ped)
    {
        Vector2 pos;
        if (RectTransformUtility.ScreenPointToLocalPointInRectangle(bimg.rectTransform,ped.position,ped.pressEventCamera,out pos))
        {
            pos.x = pos.x / (bimg.rectTransform.sizeDelta.x);
            pos.y = pos.y / (bimg.rectTransform.sizeDelta.y);

            input = new Vector3(pos.x * 2, 0, pos.y * 2);
            input = (input.magnitude > 1.0f) ? (input.normalized) : (input);

            fimg.rectTransform.anchoredPosition = new Vector3(input.x * bimg.rectTransform.sizeDelta.x / 3, input.z * bimg.rectTransform.sizeDelta.x / 3);

        }
    }

    public float Horizontal ()
    {
        return input.x;
    }
    public float Vertical ()
    {
        return input.z;
    }
}
