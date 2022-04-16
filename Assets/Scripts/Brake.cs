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
        public GameObject TGVtrain;
        private CinemachineDollyCart cinemachinedollycart;
        private CinemachineDollyCart1 cinemachinedollycart1;

        public AudioClip TGVbrake;

        AudioSource TGVbrakeAudio;

        bool trainAudioTriggered;

        // Start is called before the first frame update
        void Start()
        {
            brake.onValueChanged.AddListener((v) =>
            {
                brakevalue.text = v.ToString("0");
            });

            TGVtrain = GameObject.Find("TGV");
            cinemachinedollycart = TGVtrain.GetComponent<CinemachineDollyCart>();
            cinemachinedollycart1 = TGVtrain.GetComponent<CinemachineDollyCart1>();

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
                if (!trainAudioTriggered)
                {
                    TGVsounds.tgvnoises.PlayTGVAudioBrake();
                    trainAudioTriggered = true;
                }

                cinemachinedollycart.m_Speed = 5f;
                cinemachinedollycart1.m_Speed = 5f;

                PlayTGVAudioBrake();
            }
            else if (brake.value == 1)
            {
                if (!trainAudioTriggered)
                {
                    TGVsounds.tgvnoises.PlayTGVAudioBrake();
                    trainAudioTriggered = true;
                }

                cinemachinedollycart.m_Speed = 1f;
                cinemachinedollycart1.m_Speed = 1f;

                PlayTGVAudioBrake();
            }
            else
            {
                cinemachinedollycart.m_Speed = 0f;
                cinemachinedollycart1.m_Speed = 0f;
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
    }
}