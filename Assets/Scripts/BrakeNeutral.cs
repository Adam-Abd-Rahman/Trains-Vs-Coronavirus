using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BrakeNeutral : MonoBehaviour
{
    public GameObject Brake;
    public GameObject Brakevisible;
    public Text BrakeNeutraltext;
    private int BrakeNeutralcounter = 0;

    public void WhenBrakeNeutralIsActive()
    {
        BrakeNeutralcounter++;
        if (BrakeNeutralcounter % 2 == 1)
        {
            BrakeNeutraltext.text = "Brake Neutral (off)";
            Brake.SetActive(false);
            Brakevisible.SetActive(true);
        }
        else
        {
            BrakeNeutraltext.text = "Brake Neutral (on)";
            Brake.SetActive(true);
            Brakevisible.SetActive(false);
        }
    }
}
