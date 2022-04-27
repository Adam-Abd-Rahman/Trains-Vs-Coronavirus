using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Serialization;

namespace Cinemachine
{

    public class VACMASlider : MonoBehaviour
    {
        public GameObject VACMA;

        public Slider VACMAslider;
        public Text VACMAText;

        public void OnValueChanged(float value)
        {
            if (value == 0)
            {
                VACMAText.text = "Off";
                VACMA.SetActive(false);
                //Debug.Log("VACMA is off");
            }
            else
            {
                VACMAText.text = "On";
                VACMA.SetActive(true);
                //Debug.Log("VACMA is on");
            }
        }
    }
}
