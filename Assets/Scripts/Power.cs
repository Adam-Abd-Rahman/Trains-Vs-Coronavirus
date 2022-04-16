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
        public GameObject drivingmode;
        public float SliderValue;

        public AudioClip TGVmoving;

        AudioSource TGVmovingaudio;

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

            TGVmovingaudio = GetComponent<AudioSource>();

            //drivingmode = GameObject.Find("Driving Mode").GetComponent<Slider>().value;
            //Debug.Log(drivingmode.value);
        }

        public void OnValueChanged(float value)
        {
            SliderValue = value;
            
            if (Powerslider.value == 0f)
            {

                Brake.SetActive(true);
                BrakeHold.SetActive(true);
                BrakeNeutral.SetActive(true);
                EmergencyBrake.SetActive(true);
            }
            else if (Powerslider.value >= 1f && Powerslider.value < 60f)
            {

                cinemachinedollycart.m_Speed = cinemachinedollycart.m_Speed + 1;
                cinemachinedollycart1.m_Speed = cinemachinedollycart1.m_Speed + 1;

                Brake.SetActive(true);
                BrakeHold.SetActive(true);
                BrakeNeutral.SetActive(true);
                EmergencyBrake.SetActive(true);

                PlayTGVAudioMoving(); 
            }
            else
            {
                cinemachinedollycart.m_Speed = cinemachinedollycart.m_Speed;
                cinemachinedollycart1.m_Speed = cinemachinedollycart1.m_Speed;
    
                Brake.SetActive(true);
                BrakeHold.SetActive(true);
                BrakeNeutral.SetActive(true);
                EmergencyBrake.SetActive(true);

                PlayTGVAudioMoving();
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

            if (cinemachinedollycart.m_Speed == 0f)
            {
                TGVmovingaudio.clip = TGVmoving;
                TGVmovingaudio.Stop();
            }

            //if (cinemachinedollycart.m_Speed == 0f)
            //{
                //cinemachinedollycart.m_Speed = ;
            //}
        }

        public void PlayTGVAudioMoving()
        {
            TGVmovingaudio.clip = TGVmoving;
            TGVmovingaudio.Play();
        }

    }
}
