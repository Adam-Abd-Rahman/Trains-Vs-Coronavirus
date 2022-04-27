using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Serialization;

namespace Cinemachine
{
    public class Brake : MonoBehaviour
    {
        public Slider brake;
        public Text brakevalue;
        public Button EmergencyBrake;

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

        public AudioClip TGVbrake;

        AudioSource TGVbrakeAudio;

        // Start is called before the first frame update
        void Start()
        {
            brake.onValueChanged.AddListener((v) =>
            {
                brakevalue.text = v.ToString("0");
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

            EmergencyBrake.onClick.AddListener(ButtonClicked);
    
            TGVbrakeAudio = GetComponent<AudioSource>();
        }

        // Update is called once per frame
        void Update()
        {
            brakevalue.text = brake.value + " Bar";

            //Debug.Log(cinemachinedollycart.m_Speed);
        }

        public void OnValueChanged(float value)
        {
            if (brake.value == 2)
            {
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

                PlayTGVAudioBrake();
            }
            else if (brake.value == 1)
            {
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

                PlayTGVAudioBrake();
            }
            else
            {
                PathForEngine1.m_Speed = 0f;
                Path1ForEngine1.m_Speed = 0f;
                Path2ForEngine1.m_Speed = 0f;
                Path3ForEngine1.m_Speed = 0f;
                Path4ForEngine1.m_Speed = 0f;

                PathForEnginefrontbogie1.m_Speed = 0f;
                Path1ForEnginefrontbogie1.m_Speed = 0f;
                Path2ForEnginefrontbogie1.m_Speed = 0f;
                Path3ForEnginefrontbogie1.m_Speed = 0f;
                Path4ForEnginefrontbogie1.m_Speed = 0f;

                PathForEnginerearbogie1.m_Speed = 0f;
                Path1ForEnginerearbogie1.m_Speed = 0f;
                Path2ForEnginerearbogie1.m_Speed = 0f;
                Path3ForEnginerearbogie1.m_Speed = 0f;
                Path4ForEnginerearbogie1.m_Speed = 0f;

                StopTGVAudioBrake();
            }
        }

        public void ButtonClicked()
        {
            if (brake.value == 3)
            {
                brake.value = 0;
            }
            else
            {
                brake.value = 3;
            }
        }

        public void PlayTGVAudioBrake()
        {
            TGVbrakeAudio.clip = TGVbrake;
            TGVbrakeAudio.Play();
        }

        public void StopTGVAudioBrake()
        {
            TGVbrakeAudio.clip = TGVbrake;
            TGVbrakeAudio.Stop();
        }
    }
}