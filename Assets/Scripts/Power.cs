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
        private CinemachineDollyCart PathForEngine1;
        private CinemachineDollyCart1 Path1ForEngine1;
        private CinemachineDollyCart2 Path2ForEngine1;
        private CinemachineDollyCart3 Path3ForEngine1;
        private CinemachineDollyCart4 Path4ForEngine1;

        public GameObject TGVEnginefrontbogie1;
        private CinemachineDollyCart PathForEnginefrontbogie1;
        private CinemachineDollyCart1 Path1ForEnginefrontbogie1;
        private CinemachineDollyCart2 Path2ForEnginefrontbogie1;
        private CinemachineDollyCart3 Path3ForEnginefrontbogie1;
        private CinemachineDollyCart4 Path4ForEnginefrontbogie1;

        public GameObject TGVEnginerearbogie1;
        private CinemachineDollyCart PathForEnginerearbogie1;
        private CinemachineDollyCart1 Path1ForEnginerearbogie1;
        private CinemachineDollyCart2 Path2ForEnginerearbogie1;
        private CinemachineDollyCart3 Path3ForEnginerearbogie1;
        private CinemachineDollyCart4 Path4ForEnginerearbogie1;

        public GameObject TGVCarriage1;
        private CinemachineDollyCart PathForCarriage1;
        private CinemachineDollyCart1 Path1ForCarriage1;
        private CinemachineDollyCart2 Path2ForCarriage1;
        private CinemachineDollyCart3 Path3ForCarriage1;
        private CinemachineDollyCart4 Path4ForCarriage1;

        public GameObject TGVMiddleCarriage;
        private CinemachineDollyCart PathForMiddleCarriage;
        private CinemachineDollyCart1 Path1ForMiddleCarriage;
        private CinemachineDollyCart2 Path2ForMiddleCarriage;
        private CinemachineDollyCart3 Path3ForMiddleCarriage;
        private CinemachineDollyCart4 Path4ForMiddleCarriage;

        public GameObject TGVCarriage2;
        private CinemachineDollyCart PathForCarriage2;
        private CinemachineDollyCart1 Path1ForCarriage2;
        private CinemachineDollyCart2 Path2ForCarriage2;
        private CinemachineDollyCart3 Path3ForCarriage2;
        private CinemachineDollyCart4 Path4ForCarriage2;

        public GameObject TGVEngine2;
        private CinemachineDollyCart PathForEngine2;
        private CinemachineDollyCart1 Path1ForEngine2;
        private CinemachineDollyCart2 Path2ForEngine2;
        private CinemachineDollyCart3 Path3ForEngine2;
        private CinemachineDollyCart4 Path4ForEngine2;

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

            TGVEngine1 = GameObject.Find("Engine_1 1");
            PathForEngine1 = TGVEngine1.GetComponent<CinemachineDollyCart>();
            Path1ForEngine1 = TGVEngine1.GetComponent<CinemachineDollyCart1>();
            Path2ForEngine1 = TGVEngine1.GetComponent<CinemachineDollyCart2>();
            Path3ForEngine1 = TGVEngine1.GetComponent<CinemachineDollyCart3>();
            Path4ForEngine1 = TGVEngine1.GetComponent<CinemachineDollyCart4>();

            TGVEnginefrontbogie1 = GameObject.Find("Engine_1_front_bogie_and_wheel");
            PathForEnginefrontbogie1 = TGVEnginefrontbogie1.GetComponent<CinemachineDollyCart>();
            Path1ForEnginefrontbogie1 = TGVEnginefrontbogie1.GetComponent<CinemachineDollyCart1>();
            Path2ForEnginefrontbogie1 = TGVEnginefrontbogie1.GetComponent<CinemachineDollyCart2>();
            Path3ForEnginefrontbogie1 = TGVEnginefrontbogie1.GetComponent<CinemachineDollyCart3>();
            Path4ForEnginefrontbogie1 = TGVEnginefrontbogie1.GetComponent<CinemachineDollyCart4>();

            TGVEnginerearbogie1 = GameObject.Find("Engine_1_rear_bogie_and_wheel");
            PathForEnginerearbogie1 = TGVEnginerearbogie1.GetComponent<CinemachineDollyCart>();
            Path1ForEnginerearbogie1 = TGVEnginerearbogie1.GetComponent<CinemachineDollyCart1>();
            Path2ForEnginerearbogie1 = TGVEnginerearbogie1.GetComponent<CinemachineDollyCart2>();
            Path3ForEnginerearbogie1 = TGVEnginerearbogie1.GetComponent<CinemachineDollyCart3>();
            Path4ForEnginerearbogie1 = TGVEnginerearbogie1.GetComponent<CinemachineDollyCart4>();

            //TGVCarriage1 = GameObject.Find("Carriage_1");
            //PathForCarriage1 = TGVCarriage1.GetComponent<CinemachineDollyCart>();
            //Path1ForCarriage1 = TGVCarriage1.GetComponent<CinemachineDollyCart1>();
            //Path2ForCarriage1 = TGVCarriage1.GetComponent<CinemachineDollyCart2>();
            //Path3ForCarriage1 = TGVCarriage1.GetComponent<CinemachineDollyCart3>();
            //Path4ForCarriage1 = TGVCarriage1.GetComponent<CinemachineDollyCart4>();

            //TGVMiddleCarriage = GameObject.Find("Middle_Carriage");
            //PathForMiddleCarriage = TGVMiddleCarriage.GetComponent<CinemachineDollyCart>();
            //Path1ForMiddleCarriage = TGVMiddleCarriage.GetComponent<CinemachineDollyCart1>();
            //Path2ForMiddleCarriage = TGVMiddleCarriage.GetComponent<CinemachineDollyCart2>();
            //Path3ForMiddleCarriage = TGVMiddleCarriage.GetComponent<CinemachineDollyCart3>();
            //Path4ForMiddleCarriage = TGVMiddleCarriage.GetComponent<CinemachineDollyCart4>();

            //TGVCarriage2 = GameObject.Find("Carriage_2");
            //PathForCarriage2 = TGVCarriage2.GetComponent<CinemachineDollyCart>();
            //Path1ForCarriage2 = TGVCarriage2.GetComponent<CinemachineDollyCart1>();
            //Path2ForCarriage2 = TGVCarriage2.GetComponent<CinemachineDollyCart2>();
            //Path3ForCarriage2 = TGVCarriage2.GetComponent<CinemachineDollyCart3>();
            //Path4ForCarriage2 = TGVCarriage2.GetComponent<CinemachineDollyCart4>();

            //TGVEngine2 = GameObject.Find("Engine_2");
            //PathForEngine2 = TGVEngine2.GetComponent<CinemachineDollyCart>();
            //Path1ForEngine2 = TGVEngine2.GetComponent<CinemachineDollyCart1>();
            //Path2ForEngine2 = TGVEngine2.GetComponent<CinemachineDollyCart2>();
            //Path3ForEngine2 = TGVEngine2.GetComponent<CinemachineDollyCart3>();
            //Path4ForEngine2 = TGVEngine2.GetComponent<CinemachineDollyCart4>();

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

                //PathForCarriage1.m_Speed = 4;
                //Path1ForCarriage1.m_Speed = 4;
                //Path2ForCarriage1.m_Speed = 4;
                //Path3ForCarriage1.m_Speed = 4;
                //Path4ForCarriage1.m_Speed = 4;

                //PathForMiddleCarriage.m_Speed = 4;
                //Path1ForMiddleCarriage.m_Speed = 4;
                //Path2ForMiddleCarriage.m_Speed = 4;
                //Path3ForMiddleCarriage.m_Speed = 4;
                //Path4ForMiddleCarriage.m_Speed = 4;

                //PathForCarriage2.m_Speed = 4;
                //Path1ForCarriage2.m_Speed = 4;
                //Path2ForCarriage2.m_Speed = 4;
                //Path3ForCarriage2.m_Speed = 4;
                //Path4ForCarriage2.m_Speed = 4;

                //PathForEngine2.m_Speed = 4;
                //Path1ForEngine2.m_Speed = 4;
                //Path2ForEngine2.m_Speed = 4;
                //Path3ForEngine2.m_Speed = 4;
                //Path4ForEngine2.m_Speed = 4;

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

                //PathForCarriage1.m_Speed = 10;
                //Path1ForCarriage1.m_Speed = 10;
                //Path2ForCarriage1.m_Speed = 10;
                //Path3ForCarriage1.m_Speed = 10;
                //Path4ForCarriage1.m_Speed = 10;

                //PathForMiddleCarriage.m_Speed = 10;
                //Path1ForMiddleCarriage.m_Speed = 10;
                //Path2ForMiddleCarriage.m_Speed = 10;
                //Path3ForMiddleCarriage.m_Speed = 10;
                //Path4ForMiddleCarriage.m_Speed = 10;

                //PathForCarriage2.m_Speed = 10;
                //Path1ForCarriage2.m_Speed = 10;
                //Path2ForCarriage2.m_Speed = 10;
                //Path3ForCarriage2.m_Speed = 10;
                //Path4ForCarriage2.m_Speed = 10;

                //PathForEngine2.m_Speed = 10;
                //Path1ForEngine2.m_Speed = 10;
                //Path2ForEngine2.m_Speed = 10;
                //Path3ForEngine2.m_Speed = 10;
                //Path4ForEngine2.m_Speed = 10;

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

                //PathForCarriage1.m_Speed = 20;
                //Path1ForCarriage1.m_Speed = 20;
                //Path2ForCarriage1.m_Speed = 20;
                //Path3ForCarriage1.m_Speed = 20;
                //Path4ForCarriage1.m_Speed = 20;

                //PathForMiddleCarriage.m_Speed = 20;
                //Path1ForMiddleCarriage.m_Speed = 20;
                //Path2ForMiddleCarriage.m_Speed = 20;
                //Path3ForMiddleCarriage.m_Speed = 20;
                //Path4ForMiddleCarriage.m_Speed = 20;

                //PathForCarriage2.m_Speed = 20;
                //Path1ForCarriage2.m_Speed = 20;
                //Path2ForCarriage2.m_Speed = 20;
                //Path3ForCarriage2.m_Speed = 20;
                //Path4ForCarriage2.m_Speed = 20;

                //PathForEngine2.m_Speed = 20;
                //Path1ForEngine2.m_Speed = 20;
                //Path2ForEngine2.m_Speed = 20;
                //Path3ForEngine2.m_Speed = 20;
                //Path4ForEngine2.m_Speed = 20;

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

                //PathForCarriage1.m_Speed = 50;
                //Path1ForCarriage1.m_Speed = 50;
                //Path2ForCarriage1.m_Speed = 50;
                //Path3ForCarriage1.m_Speed = 50;
                //Path4ForCarriage1.m_Speed = 50;

                //PathForMiddleCarriage.m_Speed = 50;
                //Path1ForMiddleCarriage.m_Speed = 50;
                //Path2ForMiddleCarriage.m_Speed = 50;
                //Path3ForMiddleCarriage.m_Speed = 50;
                //Path4ForMiddleCarriage.m_Speed = 50;

                //PathForCarriage2.m_Speed = 50;
                //Path1ForCarriage2.m_Speed = 50;
                //Path2ForCarriage2.m_Speed = 50;
                //Path3ForCarriage2.m_Speed = 50;
                //Path4ForCarriage2.m_Speed = 50;

                //PathForEngine2.m_Speed = 50;
                //Path1ForEngine2.m_Speed = 50;
                //Path2ForEngine2.m_Speed = 50;
                //Path3ForEngine2.m_Speed = 50;
                //Path4ForEngine2.m_Speed = 50;

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

                //PathForCarriage1.m_Speed = 60f;
                //Path1ForCarriage1.m_Speed = 60f;
                //Path2ForCarriage1.m_Speed = 60f;
                //Path3ForCarriage1.m_Speed = 60f;
                //Path4ForCarriage1.m_Speed = 60f;

                //PathForMiddleCarriage.m_Speed = 60f;
                //Path1ForMiddleCarriage.m_Speed = 60f;
                //Path2ForMiddleCarriage.m_Speed = 60f;
                //Path3ForMiddleCarriage.m_Speed = 60f;
                //Path4ForMiddleCarriage.m_Speed = 60f;

                //PathForCarriage2.m_Speed = 60f;
                //Path1ForCarriage2.m_Speed = 60f;
                //Path2ForCarriage2.m_Speed = 60f;
                //Path3ForCarriage2.m_Speed = 60f;
                //Path4ForCarriage2.m_Speed = 60f;

                //PathForEngine2.m_Speed = 60f;
                //Path1ForEngine2.m_Speed = 60f;
                //Path2ForEngine2.m_Speed = 60f;
                //Path3ForEngine2.m_Speed = 60f;
                //Path4ForEngine2.m_Speed = 60f;

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