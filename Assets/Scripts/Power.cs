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
        public GameObject TGVtrain;
        private CinemachineDollyCart cinemachinedollycart;
        private CinemachineDollyCart1 cinemachinedollycart1;        
        public GameObject Brake;
        public GameObject EmergencyBrake;
        public GameObject Doorbutton;
        //public GameObject Doorbuttonvisible;

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

            TGVtrain = GameObject.Find("TGV");
            cinemachinedollycart = TGVtrain.GetComponent<CinemachineDollyCart>();
            cinemachinedollycart1 = TGVtrain.GetComponent<CinemachineDollyCart1>();

            TGVmovingaudio = GetComponent<AudioSource>();
        }

        public void OnValueChanged(float value)
        {
            //SliderValue = value;
            
            if (Powerslider.value == 0f)
            {

                Brake.SetActive(true);
                EmergencyBrake.SetActive(true);
            }
            else if (Powerslider.value >= 1f && Powerslider.value < 10f)
            {

                cinemachinedollycart.m_Speed = 4;
                cinemachinedollycart1.m_Speed = 4;

                Brake.SetActive(true);
                EmergencyBrake.SetActive(true);

                PlayTGVAudioMoving(); 
            }
            else if (Powerslider.value >= 10f && Powerslider.value < 20f)
            {

                cinemachinedollycart.m_Speed = 10;
                cinemachinedollycart1.m_Speed = 10;

                Brake.SetActive(true);
                EmergencyBrake.SetActive(true);

                PlayTGVAudioMoving();
            }
            else if (Powerslider.value >= 20f && Powerslider.value < 40f)
            {

                cinemachinedollycart.m_Speed = 20;
                cinemachinedollycart1.m_Speed = 20;

                Brake.SetActive(true);
                EmergencyBrake.SetActive(true);

                PlayTGVAudioMoving();
            }
            else if (Powerslider.value >= 40f && Powerslider.value < 60f)
            {

                cinemachinedollycart.m_Speed = 50;
                cinemachinedollycart1.m_Speed = 50;

                Brake.SetActive(true);
                EmergencyBrake.SetActive(true);

                PlayTGVAudioMoving();
            }
            else
            {
                cinemachinedollycart.m_Speed = 100;
                cinemachinedollycart1.m_Speed = 100;
    
                Brake.SetActive(true);
                EmergencyBrake.SetActive(true);

                PlayTGVAudioMoving();
            }
        }

        // Update is called once per frame
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
        }

        public void PlayTGVAudioMoving()
        {
            TGVmovingaudio.clip = TGVmoving;
            TGVmovingaudio.Play();
        }

    }
}
