using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Serialization;

namespace Cinemachine
{
    public class Powerselectedspeed : MonoBehaviour
    {

        public Slider Powerselectedspeedslider;
        public Text Powerselectedspeedslidervalue;

        public Slider SelectedSpeed;
        public Slider Power;

        public GameObject TGVtrain;
        private CinemachineDollyCart cinemachinedollycart;
        private CinemachineDollyCart1 cinemachinedollycart1;     
        
        public GameObject Brake;
        public GameObject EmergencyBrake;

        public AudioClip TGVmoving;

        AudioSource TGVmovingaudio;

        bool trainAudioTriggered;

        // Start is called before the first frame update
        void Start()
        {
            Powerselectedspeedslider.onValueChanged.AddListener((v) =>
            {
                Powerselectedspeedslidervalue.text = v.ToString("0");
            });

            TGVtrain = GameObject.Find("TGV");
            cinemachinedollycart = TGVtrain.GetComponent<CinemachineDollyCart>();
            cinemachinedollycart1 = TGVtrain.GetComponent<CinemachineDollyCart1>();
      
            TGVmovingaudio = GetComponent<AudioSource>();
        }

        public void OnValueChanged(float value)
        {
              
            if (Powerselectedspeedslider.value == 0f)
            {

                Brake.SetActive(true);
                EmergencyBrake.SetActive(true);
            }
            else if (Powerselectedspeedslider.value >= 1f && Powerselectedspeedslider.value < 10f)
            {

                cinemachinedollycart.m_Speed = 10;
                cinemachinedollycart1.m_Speed = 10;

                Brake.SetActive(true);
                EmergencyBrake.SetActive(true);

                PlayTGVAudioMoving(); 
            }
            else if (Powerselectedspeedslider.value >= 10f && Powerselectedspeedslider.value < 20f)
            {

                cinemachinedollycart.m_Speed = 20;
                cinemachinedollycart1.m_Speed = 20;

                Brake.SetActive(true);
                EmergencyBrake.SetActive(true);

                PlayTGVAudioMoving();
            }
            else if (Powerselectedspeedslider.value >= 20f && Powerselectedspeedslider.value < 40f)
            {

                cinemachinedollycart.m_Speed = 20;
                cinemachinedollycart1.m_Speed = 20;

                Brake.SetActive(true);
                EmergencyBrake.SetActive(true);

                PlayTGVAudioMoving();
            }
            else if (Powerselectedspeedslider.value >= 40f && Powerselectedspeedslider.value < 60f)
            {

                cinemachinedollycart.m_Speed = 50;
                cinemachinedollycart1.m_Speed = 50;

                Brake.SetActive(true);
                EmergencyBrake.SetActive(true);

                PlayTGVAudioMoving();
            }
            else
            {
                cinemachinedollycart.m_Speed = SelectedSpeed.value;
                cinemachinedollycart1.m_Speed = SelectedSpeed.value;
    
                Brake.SetActive(true);
                EmergencyBrake.SetActive(true);

                PlayTGVAudioMoving();
            }

        }

        public void Update()
        {
            if (cinemachinedollycart.m_Speed == 0f)
            {
                TGVmovingaudio.clip = TGVmoving;
                TGVmovingaudio.Stop();
            }

            Powerselectedspeedslider.value = Power.value;
        }

        public void PlayTGVAudioMoving()
        {
            TGVmovingaudio.clip = TGVmoving;
            TGVmovingaudio.Play();
        }

    }
}
