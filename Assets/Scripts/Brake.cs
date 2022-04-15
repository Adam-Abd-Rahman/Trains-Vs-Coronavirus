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
        public GameObject TGVtrain;
        private CinemachineDollyCart cinemachinedollycart;
        public CinemachineDollyCart1 cinemachinedollycart1;

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
        }

        // Update is called once per frame
        void Update()
        {
            brakevalue.text = brake.value + " Bar";

            //Debug.Log(cinemachinedollycart.m_Speed);
        }

        public void OnValueChanged(float value)
        {

            if (brake.value < 3 && brake.value >= 2)
            {
                cinemachinedollycart.m_Speed = 5f;
                cinemachinedollycart1.m_Speed = 5f;
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
            }
            else if (brake.value == 0)
            {
                if (trainAudioTriggered)
                {
                    TGVsounds.tgvnoises.StopTGVAudioBrake();
                    trainAudioTriggered = false;
                }
                cinemachinedollycart.m_Speed = 0f;
                cinemachinedollycart1.m_Speed = 0f;
            }
            else
            {
                if (trainAudioTriggered)
                {
                    TGVsounds.tgvnoises.StopTGVAudioBrake();
                    trainAudioTriggered = false;
                }
            }
        }
    }
}