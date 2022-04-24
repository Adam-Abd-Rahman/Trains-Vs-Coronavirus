using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TVMSlider : MonoBehaviour
{
    public Slider TVMslider;
    public Text TVMText;
    public GameObject TVM;
    public GameObject TVM1;
    public GameObject TVM2;

    public void OnValueChanged(float value)
    {
        if (value == 0)
        {
            TVMText.text = "Off";
            TVM.SetActive(false);
            TVM1.SetActive(false);
            TVM2.SetActive(false);
        }
        else
        {
            TVMText.text = "On";
            TVM.SetActive(true);
            TVM1.SetActive(true);
            TVM2.SetActive(true);
        }
    }
}
