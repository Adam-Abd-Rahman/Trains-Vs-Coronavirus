using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CircuitBreaker : MonoBehaviour
{
    public Text CircuitBreakerText;
    public GameObject Brake;
    public GameObject Brakevisible;
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
