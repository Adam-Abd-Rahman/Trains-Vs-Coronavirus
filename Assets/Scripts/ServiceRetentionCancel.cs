using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ServiceRetentionCancel : MonoBehaviour
{
    public GameObject AuxillaryPowerOn;
    //public GameObject AuxillaryPowerOnvisible;
    public Text ServiceRetentionCanceltext;
    private int counter = 0; 

    public void WhenServiceRetentionCancelIsClicked()
    {
        counter++; 
        if (counter % 2 == 1){
            ServiceRetentionCanceltext.text = "Service Retention Cancel (on)";
            AuxillaryPowerOn.SetActive(false);
            //AuxillaryPowerOnvisible.SetActive(true);
            //Debug.Log("Service Retention Cancel is disable." + counter);
        }
        else{
            ServiceRetentionCanceltext.text = "Service Retention Cancel (off)";
            AuxillaryPowerOn.SetActive(true);
            //AuxillaryPowerOnvisible.SetActive(false);
            //Debug.Log("Service Retention Cancel is able." + counter);
        }
    }
}
