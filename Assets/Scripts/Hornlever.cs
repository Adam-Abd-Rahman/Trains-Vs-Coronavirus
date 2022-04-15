using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hornlever : MonoBehaviour
{
    public Slider hornslider;

    bool trainHornTriggered;

    public void OnValueChanged(float value)
    {
        if (hornslider.value == 1)
        {
            if (!trainHornTriggered)
            {
                Horn.tgvtrainhorn.PlayTGVAudioHorn();
                //TGVsounds.tgvnoises.StopTGVAudioIdling();
                trainHornTriggered = true;
            }

            if (!trainHornTriggered)
            {
                TGVsounds.tgvnoises.StopTGVAudioIdling();
                trainHornTriggered = true;
            }
        }
        else
        {
            if (trainHornTriggered)
            {
                Horn.tgvtrainhorn.StopTGVAudioHorn();
                trainHornTriggered = false;
            }

            if (!trainHornTriggered)
            {
                TGVsounds.tgvnoises.PlayTGVAudioIdling();
                trainHornTriggered = false;
            }
        }
    }
}
