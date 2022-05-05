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

        public GameObject TGVdrivingcab;
        private CinemachineDollyCart0 PathFordrivingcab;
        private CinemachineDollyCart1 Path1Fordrivingcab;
        private CinemachineDollyCart2 Path2Fordrivingcab;
        private CinemachineDollyCart3 Path3Fordrivingcab;
        private CinemachineDollyCart4 Path4Fordrivingcab;

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

            TGVdrivingcab = GameObject.Find("TGV");
            PathFordrivingcab = TGVdrivingcab.GetComponent<CinemachineDollyCart0>();
            Path1Fordrivingcab = TGVdrivingcab.GetComponent<CinemachineDollyCart1>();
            Path2Fordrivingcab = TGVdrivingcab.GetComponent<CinemachineDollyCart2>();
            Path3Fordrivingcab = TGVdrivingcab.GetComponent<CinemachineDollyCart3>();
            Path4Fordrivingcab = TGVdrivingcab.GetComponent<CinemachineDollyCart4>();

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
            
            if (Powerslider.value >= 1f && Powerslider.value < 10f)
            {
                PathFordrivingcab.m_Speed = 1f;
                Path1Fordrivingcab.m_Speed = 1f;
                Path2Fordrivingcab.m_Speed = 1f;
                Path3Fordrivingcab.m_Speed = 1f;
                Path4Fordrivingcab.m_Speed = 1f;

                PathForEngine1.m_Speed = 1f;
                Path1ForEngine1.m_Speed = 1f;
                Path2ForEngine1.m_Speed = 1f;
                Path3ForEngine1.m_Speed = 1f;
                Path4ForEngine1.m_Speed = 1f;

                PathForEnginefrontbogie1.m_Speed = 1f;
                Path1ForEnginefrontbogie1.m_Speed = 1f;
                Path2ForEnginefrontbogie1.m_Speed = 1f;
                Path3ForEnginefrontbogie1.m_Speed = 1f;
                Path4ForEnginefrontbogie1.m_Speed = 1f;

                PathForEnginerearbogie1.m_Speed = 1f;
                Path1ForEnginerearbogie1.m_Speed = 1f;
                Path2ForEnginerearbogie1.m_Speed = 1f;
                Path3ForEnginerearbogie1.m_Speed = 1f;
                Path4ForEnginerearbogie1.m_Speed = 1f;

                PlayTGVAudioMoving(); 
            }
            else if (Powerslider.value >= 10f && Powerslider.value < 20f)
            {
                PathFordrivingcab.m_Speed = 2f;
                Path1Fordrivingcab.m_Speed = 2f;
                Path2Fordrivingcab.m_Speed = 2f;
                Path3Fordrivingcab.m_Speed = 2f;
                Path4Fordrivingcab.m_Speed = 2f;

                PathForEngine1.m_Speed = 2f;
                Path1ForEngine1.m_Speed = 2f;
                Path2ForEngine1.m_Speed = 2f;
                Path3ForEngine1.m_Speed = 2f;
                Path4ForEngine1.m_Speed = 2f;

                PathForEnginefrontbogie1.m_Speed = 2f;
                Path1ForEnginefrontbogie1.m_Speed = 2f;
                Path2ForEnginefrontbogie1.m_Speed = 2f;
                Path3ForEnginefrontbogie1.m_Speed = 2f;
                Path4ForEnginefrontbogie1.m_Speed = 2f;

                PathForEnginerearbogie1.m_Speed = 2f;
                Path1ForEnginerearbogie1.m_Speed = 2f;
                Path2ForEnginerearbogie1.m_Speed = 2f;
                Path3ForEnginerearbogie1.m_Speed = 2f;
                Path4ForEnginerearbogie1.m_Speed = 2f;

                PlayTGVAudioMoving();
            }
            else if (Powerslider.value >= 20f && Powerslider.value < 30f)
            {
                PathFordrivingcab.m_Speed = 3f;
                Path1Fordrivingcab.m_Speed = 3f;
                Path2Fordrivingcab.m_Speed = 3f;
                Path3Fordrivingcab.m_Speed = 3f;
                Path4Fordrivingcab.m_Speed = 3f;

                PathForEngine1.m_Speed = 3f;
                Path1ForEngine1.m_Speed = 3f;
                Path2ForEngine1.m_Speed = 3f;
                Path3ForEngine1.m_Speed = 3f;
                Path4ForEngine1.m_Speed = 3f;

                PathForEnginefrontbogie1.m_Speed = 3f;
                Path1ForEnginefrontbogie1.m_Speed = 3f;
                Path2ForEnginefrontbogie1.m_Speed = 3f;
                Path3ForEnginefrontbogie1.m_Speed = 3f;
                Path4ForEnginefrontbogie1.m_Speed = 3f;

                PathForEnginerearbogie1.m_Speed = 3f;
                Path1ForEnginerearbogie1.m_Speed = 3f;
                Path2ForEnginerearbogie1.m_Speed = 3f;
                Path3ForEnginerearbogie1.m_Speed = 3f;
                Path4ForEnginerearbogie1.m_Speed = 3f;
                
                PlayTGVAudioMoving();
            }
            else if (Powerslider.value >= 30f && Powerslider.value < 40f)
            {
                PathFordrivingcab.m_Speed = 4f;
                Path1Fordrivingcab.m_Speed = 4f;
                Path2Fordrivingcab.m_Speed = 4f;
                Path3Fordrivingcab.m_Speed = 4f;
                Path4Fordrivingcab.m_Speed = 4f;

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

                PlayTGVAudioMoving();
            }
            else if (Powerslider.value >= 40f && Powerslider.value < 50f)
            {
                PathFordrivingcab.m_Speed = 5f;
                Path1Fordrivingcab.m_Speed = 5f;
                Path2Fordrivingcab.m_Speed = 5f;
                Path3Fordrivingcab.m_Speed = 5f;
                Path4Fordrivingcab.m_Speed = 5f;

                PathForEngine1.m_Speed = 5f;
                Path1ForEngine1.m_Speed = 5f;
                Path2ForEngine1.m_Speed = 5f;
                Path3ForEngine1.m_Speed = 5f;
                Path4ForEngine1.m_Speed = 5f;

                PathForEnginefrontbogie1.m_Speed = 5f;
                Path1ForEnginefrontbogie1.m_Speed = 5f;
                Path2ForEnginefrontbogie1.m_Speed = 5f;
                Path3ForEnginefrontbogie1.m_Speed = 5f;
                Path4ForEnginefrontbogie1.m_Speed = 5f;

                PathForEnginerearbogie1.m_Speed = 5f;
                Path1ForEnginerearbogie1.m_Speed = 5f;
                Path2ForEnginerearbogie1.m_Speed = 5f;
                Path3ForEnginerearbogie1.m_Speed = 5f;
                Path4ForEnginerearbogie1.m_Speed = 5f;

                PlayTGVAudioMoving();
            }
            else if (Powerslider.value >= 50f && Powerslider.value < 60f)
            {
                PathFordrivingcab.m_Speed = 6f;
                Path1Fordrivingcab.m_Speed = 6f;
                Path2Fordrivingcab.m_Speed = 6f;
                Path3Fordrivingcab.m_Speed = 6f;
                Path4Fordrivingcab.m_Speed = 6f;

                PathForEngine1.m_Speed = 6f;
                Path1ForEngine1.m_Speed = 6f;
                Path2ForEngine1.m_Speed = 6f;
                Path3ForEngine1.m_Speed = 6f;
                Path4ForEngine1.m_Speed = 6f;

                PathForEnginefrontbogie1.m_Speed = 6f;
                Path1ForEnginefrontbogie1.m_Speed = 6f;
                Path2ForEnginefrontbogie1.m_Speed = 6f;
                Path3ForEnginefrontbogie1.m_Speed = 6f;
                Path4ForEnginefrontbogie1.m_Speed = 6f;

                PathForEnginerearbogie1.m_Speed = 6f;
                Path1ForEnginerearbogie1.m_Speed = 6f;
                Path2ForEnginerearbogie1.m_Speed = 6f;
                Path3ForEnginerearbogie1.m_Speed = 6f;
                Path4ForEnginerearbogie1.m_Speed = 6f;

                PlayTGVAudioMoving();
            }
            else
            {
                PathFordrivingcab.m_Speed = 10f;
                Path1Fordrivingcab.m_Speed = 10f;
                Path2Fordrivingcab.m_Speed = 10f;
                Path3Fordrivingcab.m_Speed = 10f;
                Path4Fordrivingcab.m_Speed = 10f;

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

                PlayTGVAudioMoving();
            }
        }

        // Update is called once per frame
        public void Update()
        {
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