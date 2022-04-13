using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Brake : MonoBehaviour
{
    public Slider brake;
    public Text brakevalue;

    bool trainAudioTriggered;

    // Start is called before the first frame update
    void Start()
    {
        brake.onValueChanged.AddListener((v) => {
            brakevalue.text = v.ToString("0"); 
        }); 
    }

    // Update is called once per frame
    void Update()
    {
        brakevalue.text = brakevalue.text + "Bar";
    }

    public void OnValueChanged(float value)
    {
        if (brake.value < 3)
        {
            if (!trainAudioTriggered)
            {
                TGVsounds.tgvnoises.PlayTGVAudioBrake();
                trainAudioTriggered = true;
            }
        }
        else
        {
            if (trainAudioTriggered)
            {
                TGVsounds.tgvnoises.StopTGVAudioBrake();
                trainAudioTriggered = false;
            }
        }

    }
}
