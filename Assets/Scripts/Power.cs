using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Serialization;

namespace Cinemachine
{
    public class Power : MonoBehaviour
    {
        public Slider Powerslider;
        public Text Powervalue;
        //public SpeedSelector selectyourspeed;
        public GameObject TGVtrain;
        private CinemachineDollyCart cinemachinedollycart;
        private CinemachineDollyCart1 cinemachinedollycart1;        
        public GameObject Brake;
        public GameObject BrakeHold;
        public GameObject BrakeNeutral;
        public GameObject EmergencyBrake;
        public GameObject Doorbutton;
        //public GameObject Doorbuttonvisible;
        //public GameObject ManualControlSpeed;
        //private DrivingMode drivingmode;
        public float SliderValue;

        bool trainAudioTriggered;
        
        // Start is called before the first frame update
        void Start()
        {
            Powerslider.onValueChanged.AddListener((v) =>
            {
                Powervalue.text = v.ToString("0");
            });

            //Powerslider.maxValue = 10;

            TGVtrain = GameObject.Find("TGV");
            cinemachinedollycart = TGVtrain.GetComponent<CinemachineDollyCart>();
            cinemachinedollycart1 = TGVtrain.GetComponent<CinemachineDollyCart1>();

            //ManualControlSpeed = GameObject.Find("Driving Mode");
            //drivingmode = ManualControlSpeed.GetComponent<DrivingMode>();
        }

        public void OnValueChanged(float value)
        {
            SliderValue = value;
            
            if (Powerslider.value == 0f)
            {
                if (!trainAudioTriggered)
                {
                    TGVsounds.tgvnoises.PlayTGVAudioIdling();
                    trainAudioTriggered = true;
                }

                Brake.SetActive(true);
                BrakeHold.SetActive(true);
                BrakeNeutral.SetActive(true);
                EmergencyBrake.SetActive(true);
            }
            else if (Powerslider.value >= 1f && Powerslider.value < 60f)
            {
                if (!trainAudioTriggered)
                {
                    TGVsounds.tgvnoises.PlayTGVAudioMoving();
                    trainAudioTriggered = true;
                }

                cinemachinedollycart.m_Speed = cinemachinedollycart.m_Speed + 1;
                cinemachinedollycart1.m_Speed = cinemachinedollycart1.m_Speed + 1;

                Brake.SetActive(true);
                BrakeHold.SetActive(true);
                BrakeNeutral.SetActive(true);
                EmergencyBrake.SetActive(true);
            }
            else
            {
                cinemachinedollycart.m_Speed = cinemachinedollycart.m_Speed;
                cinemachinedollycart1.m_Speed = cinemachinedollycart1.m_Speed;
    
                Brake.SetActive(true);
                BrakeHold.SetActive(true);
                BrakeNeutral.SetActive(true);
                EmergencyBrake.SetActive(true);
            }
        }

        public void Update()
        {
            if (cinemachinedollycart.m_Speed >= 1f)
            {
                Doorbutton.SetActive(false);
                //Doorbuttonvisible.SetActive(true);
            }
            else
            {
                Doorbutton.SetActive(true);
                //Doorbuttonvisible.SetActive(false);
            }
        }
                
    }
}
