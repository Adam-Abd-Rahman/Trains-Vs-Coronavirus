using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrivingMode : MonoBehaviour
{
    public Slider Drivingmode;
    public Text DrivingmodeText;
    public GameObject ManualControl;
    public GameObject SpeedselectorControl;
    //public GameObject SpeedselectorControlvisible;

    public void WhenDrivingModeIsActive(float value)
    {
        if (value == 0)
        {
            DrivingmodeText.text = "Off";
            //ManualControl.SetActive(false);
            SpeedselectorControl.SetActive(false);
            //SpeedselectorControlvisible.SetActive(true);
            Debug.Log("Driving mode is off." + value);
        }
        else if (value == 1)
        {
            DrivingmodeText.text = "Manual control";
            //ManualControl.SetActive(true);
            SpeedselectorControl.SetActive(false);
            //SpeedselectorControlvisible.SetActive(true);
            Debug.Log("Using Manual Control." + value);
        }
        else
        {
            DrivingmodeText.text = "Selected speed control";
            //ManualControl.SetActive(false);
            SpeedselectorControl.SetActive(true);
            //SpeedselectorControlvisible.SetActive(false);
            Debug.Log("Using the speed selector." + value);
        }
    }
}
