using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BrakeNeutral : MonoBehaviour
{
    public GameObject Brake;
    public Text BrakeNeutraltext;
    private int BrakeNeutralcounter = 0;

    public void BrakeNeutralTextIsActive()
    {
        BrakeNeutralcounter++;
        if (BrakeNeutralcounter % 2 == 1)
        {
            BrakeNeutraltext.text = "Brake Neutral (off)";
        }
        else
        {
            BrakeNeutraltext.text = "Brake Neutral (on)";
        }
    }

    public void WhenBrakeNeutralIsActive()
    {
        if (Brake != null)
        {
            bool isActive = Brake.activeSelf;
            Brake.SetActive(!isActive);
        }
    }
}
