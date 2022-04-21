using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AuxilliaryPowerOn : MonoBehaviour
{
    public GameObject MasterSwitch;
    public GameObject MasterSwitchvisible;

    public void WhenAuxilliaryPowerOnIsActive(bool tglValue)
    {
        bool onoffSwitch = gameObject.GetComponent<Toggle>().isOn; 
        if (onoffSwitch)
        {
            MasterSwitch.SetActive(true);
            MasterSwitchvisible.SetActive(false);
            //Debug.Log("Master Switch is on");
        }
        else {
            MasterSwitch.SetActive(false);
            MasterSwitchvisible.SetActive(true);
            //Debug.Log("Master Switch is off");
        }
    }
}
