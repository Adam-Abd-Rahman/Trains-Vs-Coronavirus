using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TVMSlider : MonoBehaviour
{
    public Slider TVMslider;
    public Text TVMText;
    public GameObject TVM;

    public void OnValueChanged(float value)
    {
        if (value == 0)
        {
            TVMText.text = "Off";
            TVM.SetActive(false);
        }
        else
        {
            TVMText.text = "On";
            TVM.SetActive(true);
        }
    }
}
