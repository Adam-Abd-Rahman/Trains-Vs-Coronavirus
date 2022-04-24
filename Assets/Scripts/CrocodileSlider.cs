using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrocodileSlider : MonoBehaviour
{
    public Slider Crocodileslider;
    public Text CrocodileText;
    public GameObject Crocodile;

    public void OnValueChanged(float value)
    {
        if (value == 0)
        {
            CrocodileText.text = "Off";
            Crocodile.SetActive(false);
            //Debug.Log("Crocodile is off");
        }
        else
        {
            CrocodileText.text = "On";
            Crocodile.SetActive(true);
        }
    }
}
