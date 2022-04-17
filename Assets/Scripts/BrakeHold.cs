using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BrakeHold : MonoBehaviour
{

    public GameObject EmergencyBrake;
    public GameObject EmergencyBrakevisible;
    public GameObject GameScore;
    public GameObject GameOver;
    public GameObject Brake;
    public GameObject Brakevisible;
    //public GameObject Brakeneutral;
    public Text BrakeHoldtext;
    private int BrakeHoldcounter = 0;

    public void BrakeHoldButtonIsActive()
    {
        BrakeHoldcounter++;
        if (BrakeHoldcounter % 2 == 1)
        {
            BrakeHoldtext.text = "Brake Hold (off)";
            GameScore.SetActive(true);
            GameOver.SetActive(true);
            //Debug.Log("Brake Hold is off." + BrakeHoldcounter);
        }
        else
        {
            BrakeHoldtext.text = "Brake Hold (on)";
            GameScore.SetActive(false);
            GameOver.SetActive(false);
            //Debug.Log("Circuit Breaker is on." + BrakeHoldcounter);
        }
    }
}
