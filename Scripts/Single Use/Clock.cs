using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    public Material minutesDigits, minutesDecimals, secondsDigits, secondsDecimals;
    public Texture[] digits;
    public DoorControl door;

    private int mDigits=0, mDecimals=2, sDigits=0, sDecimals=0;
    private Gyroscope gyro;

    private void Start()
    {
        gyro = Input.gyro;
        gyro.enabled = true;
        StartCoroutine(timer());
    }

    IEnumerator timer()
    {
        while ((mDecimals != 0) || (mDigits != 0) || (sDigits != 0) || (sDecimals != 0) || (sDigits != 0))
        {
            if (sDigits == 0)
            {
                sDigits = 9;
                secondsDigits.mainTexture = digits[sDigits];
                if (sDecimals == 0)
                {
                    sDecimals = 5;
                    secondsDecimals.mainTexture = digits[sDecimals];
                    if (mDigits == 0)
                    {
                        mDigits = 9;
                        minutesDigits.mainTexture = digits[mDigits];
                        mDecimals--;
                        minutesDecimals.mainTexture = digits[mDecimals];
                    }
                    else
                    {
                        mDigits--;
                        minutesDigits.mainTexture = digits[mDigits];
                    }
                }
                else
                {
                    sDecimals--;
                    secondsDecimals.mainTexture = digits[sDecimals];
                }
            }
            else
            {
                sDigits--;
                secondsDigits.mainTexture = digits[sDigits];
            }

            if ((Mathf.Abs(gyro.userAcceleration.x) + Mathf.Abs(gyro.userAcceleration.y) + Mathf.Abs(gyro.userAcceleration.z)) < 1)
                yield return new WaitForSeconds(1);
            else
                yield return new WaitForSeconds(1 / 40);

        }
        door.Open();
    }
}
