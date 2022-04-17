using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedSelector : MonoBehaviour
{
    public Slider SelectedSpeed;
    public Text SpeedSelectorvalue;
    public Slider Powersliderselectedspeed;

    // Start is called before the first frame update
    void Start()
    {
        SelectedSpeed.onValueChanged.AddListener((v) => {
            SpeedSelectorvalue.text = v.ToString("0");
        });

        Powersliderselectedspeed = GameObject.Find("Power (speedselector)").GetComponent<Slider>();
    }

    void Update()
    {
        Debug.Log(Powersliderselectedspeed.value);
    }

    public void OnValueChanged(float value)
    {
        Debug.Log("New Value" + value);
        //Powerslider.maxValue = value;
    }

}
