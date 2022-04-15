using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PantographMode : MonoBehaviour
{
    public Slider Pantographmode;
    public Text PantographModeText;

    public void WhenPantographModeIsActive(float value)
    {
        if (value == 0)
        {
            PantographModeText.text = "AC";
            //Debug.Log("Using AC power supply." + value);
        }
        else if (value == 1)
        {
            PantographModeText.text = "DC";
            //Debug.Log("Using DC power supply." + value);
        }
        else
        {
            PantographModeText.text = "LGV";
            //Debug.Log("Using LGV power supply." + value);
        }
    }

}
