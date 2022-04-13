using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EmergencyBrake : MonoBehaviour
{
    public Text EmergencyBraketext;
    public Text EmergencyBrakevalue;
    private int EmergencyBrakecounter = 0;
    private int EmergencyBrakevaluecounter = 0;

    public void EmergencyBrakeTextIsActive()
    {
        EmergencyBrakecounter++;
        if (EmergencyBrakecounter % 2 == 1)
        {
            EmergencyBraketext.text = "Emergency Brake (on)";
        }
        else
        {
            EmergencyBraketext.text = "Emergency Brake (off)";
        }
    }

    public void WhenEmergencyBrakeIsActive()
    {
        EmergencyBrakevaluecounter++;
        if (EmergencyBrakevaluecounter % 2 == 1)
        {
            EmergencyBrakevalue.text = "0";
        }
        else
        {
            EmergencyBrakevalue.text = "3";
        }        
    }
}
