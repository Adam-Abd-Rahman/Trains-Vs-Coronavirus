using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrivingMode : MonoBehaviour
{
    public Slider Drivingmode;
    public GameObject Powerslider;    
    public GameObject Powersliderselectedspeed;
    public GameObject Powerslidervisible;
    public Text DrivingmodeText;
    public GameObject SpeedselectorControl;
    //public GameObject SpeedselectorControlvisible;

    public void WhenDrivingModeIsActive(float value)
    {
        if (value == 0)
        {
            DrivingmodeText.text = "Off";
            SpeedselectorControl.SetActive(false);
            //SpeedselectorControlvisible.SetActive(true);
            Powerslider.SetActive(false);
            Powersliderselectedspeed.SetActive(false);
            Powerslidervisible.SetActive(true);
            //Debug.Log("Driving mode is off." + value);
        }
        else if (value == 1)
        {
            DrivingmodeText.text = "Manual control";
            SpeedselectorControl.SetActive(false);
            //SpeedselectorControlvisible.SetActive(true);
            Powerslider.SetActive(true);
            Powersliderselectedspeed.SetActive(false);
            Powerslidervisible.SetActive(false);
            //Debug.Log("Using Manual Control." + value);
        }
        else
        {
            DrivingmodeText.text = "Selected speed control";
            SpeedselectorControl.SetActive(true);
            //SpeedselectorControlvisible.SetActive(false);
            Powerslider.SetActive(false);
            Powersliderselectedspeed.SetActive(true);
            Powerslidervisible.SetActive(false);
            //Debug.Log("Using the speed selector." + value);
        }
    }
}
