using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CircuitBreaker : MonoBehaviour
{
    public Text CircuitBreakerText;
    public GameObject Brake;
    public GameObject Brakevisible;
    public GameObject BrakeHold;
    //public GameObject BrakeHoldvisible;
    public GameObject BrakeNeutral;
    //public GameObject BrakeNeutralvisible;
    public GameObject EmergencyBrake;
    public GameObject EmergencyBrakevisible;
    public GameObject Drivingmode;
    //public GameObject Drivingmodevisible;
    public GameObject Doorbutton;
    //public GameObject Doorbuttonvisible;
    private int CircuitBreakercounter = 0; 

    public void WhenCircuitBreakerIsActive()
    {
        CircuitBreakercounter++;
        if (CircuitBreakercounter % 2 == 1)
        {
            CircuitBreakerText.text = "Circuit Breaker (on)";
            BrakeHold.SetActive(true);
            //BrakeHoldvisible.SetActive(false);
            BrakeNeutral.SetActive(true);
            //BrakeNeutralvisible.SetActive(false);
            EmergencyBrake.SetActive(true);
            EmergencyBrakevisible.SetActive(false);
            Brake.SetActive(true);
            Brakevisible.SetActive(false);
            Drivingmode.SetActive(true);
            //Drivingmodevisible.SetActive(false);
            Doorbutton.SetActive(true);
            //Doorbuttonvisible.SetActive(false);
            //Debug.Log("Circuit Breaker is disable." + CircuitBreakercounter);
        }
        else
        {
            CircuitBreakerText.text = "Circuit Breaker (off)";
            BrakeHold.SetActive(false);
            //BrakeHoldvisible.SetActive(true);
            BrakeNeutral.SetActive(false);
            //BrakeNeutralvisible.SetActive(true);
            EmergencyBrake.SetActive(false);
            EmergencyBrakevisible.SetActive(true);
            Brake.SetActive(false);
            Brakevisible.SetActive(true);
            Drivingmode.SetActive(false);
            //Drivingmodevisible.SetActive(true);
            Doorbutton.SetActive(false);
            //Doorbuttonvisible.SetActive(true);
            //Debug.Log("Circuit Breaker is able." + CircuitBreakercounter);
        }
    }

}
