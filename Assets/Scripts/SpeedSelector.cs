using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedSelector : MonoBehaviour
{
    public Slider SelectedSpeed;
    public Slider Power;
    public Text SpeedSelectorvalue;

    // Start is called before the first frame update
    void Start()
    {
        SelectedSpeed.onValueChanged.AddListener((v) => {
            SpeedSelectorvalue.text = v.ToString("0");
        });

        // Changes the max value of the slider to 300;
        SelectedSpeed.maxValue = 300;
    }
}
