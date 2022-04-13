using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Serialization;

public class Power : MonoBehaviour
{
        public Slider Powerslider;
        public Text Powervalue;
        public GameObject Brake;
        public GameObject BrakeHold;
        public GameObject BrakeNeutral;
        public GameObject EmergencyBrake;
        public GameObject Doorbutton;
        //public GameObject Doorbuttonvisible;
        
        private static float TrainSpeed = 0;

        bool trainAudioTriggered; 

        // Start is called before the first frame update
        void Start()
        {
            Powerslider.onValueChanged.AddListener((v) => {
                Powervalue.text = v.ToString("0");
            });
        }

    public void OnValueChanged(float value)
    {
        if (value >= 1)
        {
            Brake.SetActive(true);
            BrakeHold.SetActive(true);
            BrakeNeutral.SetActive(true);
            EmergencyBrake.SetActive(true);
            Doorbutton.SetActive(false);
            //Doorbuttonvisible.SetActive(true);
        }
        else
        {
            Brake.SetActive(true);
            BrakeHold.SetActive(true);
            BrakeNeutral.SetActive(true);
            EmergencyBrake.SetActive(true);
            Doorbutton.SetActive(true);
            //Doorbuttonvisible.SetActive(false);
        }

        TrainSpeed = Powerslider.value;
        Debug.Log("Current Train Speed:" + TrainSpeed);

        if (Powerslider.value == 0)
        {
            if (!trainAudioTriggered)
            {
                TGVsounds.tgvnoises.PlayTGVAudioIdling();
                trainAudioTriggered = true;
            }
        }
        else if (Powerslider.value >= 1 && Powerslider.value < 50)
        {
            if (trainAudioTriggered)
            {
                TGVsounds.tgvnoises.PlayTGVAudioAccelerate();
                trainAudioTriggered = false;
            }
        }
        else
        {
            if (!trainAudioTriggered)
            {
                TGVsounds.tgvnoises.PlayTGVAudioMoving();
                trainAudioTriggered = true;
            }
        }
    }
}
