using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrivingMode : MonoBehaviour
{
    public Slider Drivingmode;
    public Text DrivingmodeText;

    public GameObject Powerslider;
    public GameObject Powerslidervisible;

    public GameObject CountdownTimer;

    public GameObject SpeedselectorControl;
    public GameObject SpeedselectorControlvisible;

    public void WhenDrivingModeIsActive(float value)
    {
        if (value == 0)
        {
            DrivingmodeText.text = "Off";
            SpeedselectorControl.SetActive(false);
            //SpeedselectorControlvisible.SetActive(true);
            Powerslider.SetActive(false);
            Powerslidervisible.SetActive(true);
            //Debug.Log("Driving mode is off." + value);
        }
        else if (value == 1)
        {
            DrivingmodeText.text = "Manual control";
            SpeedselectorControl.SetActive(false);
            //SpeedselectorControlvisible.SetActive(true);
            Powerslider.SetActive(true);
            Powerslidervisible.SetActive(false);
            CountdownTimer.SetActive(true);
            //Debug.Log("Using Manual Control." + value);
        }
        else
        {
            DrivingmodeText.text = "Selected speed control";
            SpeedselectorControl.SetActive(true);
            //SpeedselectorControlvisible.SetActive(false);
            Powerslider.SetActive(true);
            Powerslidervisible.SetActive(false);
            CountdownTimer.SetActive(true);
            //Debug.Log("Using the speed selector." + value);
        }
    }    
}
