using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedSelector : MonoBehaviour
{
    public Slider SelectedSpeed;
    public Slider Powerslider;
    public Text SpeedSelectorvalue;

    // Start is called before the first frame update
    void Start()
    {
        SelectedSpeed.onValueChanged.AddListener((v) => {
            SpeedSelectorvalue.text = v.ToString("0");
        });

        //Powerslider = GameObject.Find("Power").GetComponent<Slider>();
        //Debug.Log(Powerslider.maxValue);
    }

    public void OnValueChanged(float value)
    {
        //Debug.Log("New Value" + value);
        //Powerslider.maxValue = value;
    }

}
