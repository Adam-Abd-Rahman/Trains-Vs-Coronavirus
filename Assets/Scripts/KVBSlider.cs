using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KVBSlider : MonoBehaviour
{
    public Slider KVBslider;
    public Text KVBText;
    public GameObject KVB;

    public void OnValueChanged(float value)
    {
        if (value == 0)
        {
            KVBText.text = "Off";
            KVB.SetActive(false);
        }
        else
        {
            KVBText.text = "On";
            KVB.SetActive(true);
        }
    }
}
