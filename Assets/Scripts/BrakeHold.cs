using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BrakeHold : MonoBehaviour
{
    public GameObject Power;
    public GameObject Powervisible;
    public GameObject GameScore;
    public Text BrakeHoldtext;
    private int BrakeHoldcounter = 0;

    public void BrakeHoldButtonIsActive()
    {
        BrakeHoldcounter++;
        if (BrakeHoldcounter % 2 == 1)
        {
            BrakeHoldtext.text = "Brake Hold (off)";
            Power.SetActive(true);
            Powervisible.SetActive(false);
            GameScore.SetActive(false);
            Debug.Log("Brake Hold is off." + BrakeHoldcounter);

        }
        else
        {
            BrakeHoldtext.text = "Brake Hold (on)";
            Power.SetActive(false);
            Powervisible.SetActive(true);
            GameScore.SetActive(true);
            Debug.Log("Circuit Breaker is on." + BrakeHoldcounter);

        }
    }
}
