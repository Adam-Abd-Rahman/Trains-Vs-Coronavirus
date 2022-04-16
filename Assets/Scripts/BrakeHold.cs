using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BrakeHold : MonoBehaviour
{

    public GameObject EmergencyBrake;
    public GameObject EmergencyBrakevisible;
    public Text BrakeHoldtext;
    private int BrakeHoldcounter = 0;

    public void BrakeHoldButtonIsActive()
    {
        BrakeHoldcounter++;
        if (BrakeHoldcounter % 2 == 1)
        {
            BrakeHoldtext.text = "Brake Hold (off)";
            EmergencyBrake.SetActive(true);
            EmergencyBrakevisible.SetActive(false);
            //Debug.Log("Brake Hold is off." + BrakeHoldcounter);
        }
        else
        {
            BrakeHoldtext.text = "Brake Hold (on)";
            EmergencyBrake.SetActive(false);
            EmergencyBrakevisible.SetActive(true);
            //Debug.Log("Circuit Breaker is on." + BrakeHoldcounter);
        }
    }
}
