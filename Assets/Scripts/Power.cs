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

        public GameObject TGVEngine1;
        private CinemachineDollyCart0 PathForEngine1;
        private CinemachineDollyCart1 Path1ForEngine1;
        private CinemachineDollyCart2 Path2ForEngine1;
        private CinemachineDollyCart3 Path3ForEngine1;
        private CinemachineDollyCart4 Path4ForEngine1;

        public GameObject TGVEnginefrontbogie1;
        private CinemachineDollyCart0 PathForEnginefrontbogie1;
        private CinemachineDollyCart1 Path1ForEnginefrontbogie1;
        private CinemachineDollyCart2 Path2ForEnginefrontbogie1;
        private CinemachineDollyCart3 Path3ForEnginefrontbogie1;
        private CinemachineDollyCart4 Path4ForEnginefrontbogie1;

        public GameObject TGVEnginerearbogie1;
        private CinemachineDollyCart0 PathForEnginerearbogie1;
        private CinemachineDollyCart1 Path1ForEnginerearbogie1;
        private CinemachineDollyCart2 Path2ForEnginerearbogie1;
        private CinemachineDollyCart3 Path3ForEnginerearbogie1;
        private CinemachineDollyCart4 Path4ForEnginerearbogie1;
        
        public GameObject Brake;
        public GameObject EmergencyBrake;
        public GameObject Doorbutton;
        //public GameObject Doorbuttonvisible;

        public Slider Drivingmode;

        public Slider Speedselector;

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

            TGVEngine1 = GameObject.Find("Engine_1_1");
            PathForEngine1 = TGVEngine1.GetComponent<CinemachineDollyCart0>();
            Path1ForEngine1 = TGVEngine1.GetComponent<CinemachineDollyCart1>();
            Path2ForEngine1 = TGVEngine1.GetComponent<CinemachineDollyCart2>();
            Path3ForEngine1 = TGVEngine1.GetComponent<CinemachineDollyCart3>();
            Path4ForEngine1 = TGVEngine1.GetComponent<CinemachineDollyCart4>();

            TGVEnginefrontbogie1 = GameObject.Find("Engine_1_front_bogie_and_wheel");
            PathForEnginefrontbogie1 = TGVEnginefrontbogie1.GetComponent<CinemachineDollyCart0>();
            Path1ForEnginefrontbogie1 = TGVEnginefrontbogie1.GetComponent<CinemachineDollyCart1>();
            Path2ForEnginefrontbogie1 = TGVEnginefrontbogie1.GetComponent<CinemachineDollyCart2>();
            Path3ForEnginefrontbogie1 = TGVEnginefrontbogie1.GetComponent<CinemachineDollyCart3>();
            Path4ForEnginefrontbogie1 = TGVEnginefrontbogie1.GetComponent<CinemachineDollyCart4>();

            TGVEnginerearbogie1 = GameObject.Find("Engine_1_rear_bogie_and_wheel");
            PathForEnginerearbogie1 = TGVEnginerearbogie1.GetComponent<CinemachineDollyCart0>();
            Path1ForEnginerearbogie1 = TGVEnginerearbogie1.GetComponent<CinemachineDollyCart1>();
            Path2ForEnginerearbogie1 = TGVEnginerearbogie1.GetComponent<CinemachineDollyCart2>();
            Path3ForEnginerearbogie1 = TGVEnginerearbogie1.GetComponent<CinemachineDollyCart3>();
            Path4ForEnginerearbogie1 = TGVEnginerearbogie1.GetComponent<CinemachineDollyCart4>();

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

                PathForEngine1.m_Speed = 4f;
                Path1ForEngine1.m_Speed = 4f;
                Path2ForEngine1.m_Speed = 4f;
                Path3ForEngine1.m_Speed = 4f;
                Path4ForEngine1.m_Speed = 4f;

                PathForEnginefrontbogie1.m_Speed = 4f;
                Path1ForEnginefrontbogie1.m_Speed = 4f;
                Path2ForEnginefrontbogie1.m_Speed = 4f;
                Path3ForEnginefrontbogie1.m_Speed = 4f;
                Path4ForEnginefrontbogie1.m_Speed = 4f;

                PathForEnginerearbogie1.m_Speed = 4f;
                Path1ForEnginerearbogie1.m_Speed = 4f;
                Path2ForEnginerearbogie1.m_Speed = 4f;
                Path3ForEnginerearbogie1.m_Speed = 4f;
                Path4ForEnginerearbogie1.m_Speed = 4f;

                Brake.SetActive(true);
                EmergencyBrake.SetActive(true);

                PlayTGVAudioMoving(); 
            }
            else if (Powerslider.value >= 10f && Powerslider.value < 20f)
            {
                PathForEngine1.m_Speed = 10f;
                Path1ForEngine1.m_Speed = 10f;
                Path2ForEngine1.m_Speed = 10f;
                Path3ForEngine1.m_Speed = 10f;
                Path4ForEngine1.m_Speed = 10f;

                PathForEnginefrontbogie1.m_Speed = 10f;
                Path1ForEnginefrontbogie1.m_Speed = 10f;
                Path2ForEnginefrontbogie1.m_Speed = 10f;
                Path3ForEnginefrontbogie1.m_Speed = 10f;
                Path4ForEnginefrontbogie1.m_Speed = 10f;

                PathForEnginerearbogie1.m_Speed = 10f;
                Path1ForEnginerearbogie1.m_Speed = 10f;
                Path2ForEnginerearbogie1.m_Speed = 10f;
                Path3ForEnginerearbogie1.m_Speed = 10f;
                Path4ForEnginerearbogie1.m_Speed = 10f;

                Brake.SetActive(true);
                EmergencyBrake.SetActive(true);

                PlayTGVAudioMoving();
            }
            else if (Powerslider.value >= 20f && Powerslider.value < 40f)
            {

                PathForEngine1.m_Speed = 20f;
                Path1ForEngine1.m_Speed = 20f;
                Path2ForEngine1.m_Speed = 20f;
                Path3ForEngine1.m_Speed = 20f;
                Path4ForEngine1.m_Speed = 20f;

                PathForEnginefrontbogie1.m_Speed = 20f;
                Path1ForEnginefrontbogie1.m_Speed = 20f;
                Path2ForEnginefrontbogie1.m_Speed = 20f;
                Path3ForEnginefrontbogie1.m_Speed = 20f;
                Path4ForEnginefrontbogie1.m_Speed = 20f;

                PathForEnginerearbogie1.m_Speed = 20f;
                Path1ForEnginerearbogie1.m_Speed = 20f;
                Path2ForEnginerearbogie1.m_Speed = 20f;
                Path3ForEnginerearbogie1.m_Speed = 20f;
                Path4ForEnginerearbogie1.m_Speed = 20f;

                Brake.SetActive(true);
                EmergencyBrake.SetActive(true);

                PlayTGVAudioMoving();
            }
            else if (Powerslider.value >= 40f && Powerslider.value < 60f)
            {
                PathForEngine1.m_Speed = 50f;
                Path1ForEngine1.m_Speed = 50f;
                Path2ForEngine1.m_Speed = 50f;
                Path3ForEngine1.m_Speed = 50f;
                Path4ForEngine1.m_Speed = 50f;

                PathForEnginefrontbogie1.m_Speed = 50f;
                Path1ForEnginefrontbogie1.m_Speed = 50f;
                Path2ForEnginefrontbogie1.m_Speed = 50f;
                Path3ForEnginefrontbogie1.m_Speed = 50f;
                Path4ForEnginefrontbogie1.m_Speed = 50f;

                PathForEnginerearbogie1.m_Speed = 50f;
                Path1ForEnginerearbogie1.m_Speed = 50f;
                Path2ForEnginerearbogie1.m_Speed = 50f;
                Path3ForEnginerearbogie1.m_Speed = 50f;
                Path4ForEnginerearbogie1.m_Speed = 50f;

                Brake.SetActive(true);
                EmergencyBrake.SetActive(true);

                PlayTGVAudioMoving();
            }
            else
            {
                PathForEngine1.m_Speed = 60f;
                Path1ForEngine1.m_Speed = 60f;
                Path2ForEngine1.m_Speed = 60f;
                Path3ForEngine1.m_Speed = 60f;
                Path4ForEngine1.m_Speed = 60f;

                PathForEnginefrontbogie1.m_Speed = 60f;
                Path1ForEnginefrontbogie1.m_Speed = 60f;
                Path2ForEnginefrontbogie1.m_Speed = 60f;
                Path3ForEnginefrontbogie1.m_Speed = 60f;
                Path4ForEnginefrontbogie1.m_Speed = 60f;

                PathForEnginerearbogie1.m_Speed = 60f;
                Path1ForEnginerearbogie1.m_Speed = 60f;
                Path2ForEnginerearbogie1.m_Speed = 60f;
                Path3ForEnginerearbogie1.m_Speed = 60f;
                Path4ForEnginerearbogie1.m_Speed = 60f;

                Brake.SetActive(true);
                EmergencyBrake.SetActive(true);

                PlayTGVAudioMoving();
            }
        }

        // Update is called once per frame
        public void Update()
        {
            if (PathForEngine1.m_Speed >= 1f)
            {
                Doorbutton.SetActive(false);
                //Doorbuttonvisible.SetActive(true);
            }
            else
            {
                Doorbutton.SetActive(true);
                //Doorbuttonvisible.SetActive(false);
            }

            if (PathForEngine1.m_Speed == 0f)
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