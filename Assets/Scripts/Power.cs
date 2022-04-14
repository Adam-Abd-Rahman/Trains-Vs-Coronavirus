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
        public SpeedSelector selectyourspeed;
        public GameObject TGVtrain;
        //public CinemachineDollyCart1 TrainSpeed1;        
        public GameObject Brake;
        public GameObject BrakeHold;
        public GameObject BrakeNeutral;
        public GameObject EmergencyBrake;
        public GameObject Doorbutton;
        //public GameObject Doorbuttonvisible;
        public float maxspeed = 10.0f;
        public float timeZeroToMax = 0.5f;
        float accelRatePerSecond;
        float forwardVelocity;
        public Rigidbody rb;

        bool trainAudioTriggered;
        
        // Start is called before the first frame update
        void Start()
        {
            Powerslider.onValueChanged.AddListener((v) =>
            {
                Powervalue.text = v.ToString("0");
            });

            //Powerslider.maxValue = 300;
    
            rb = TGVtrain.GetComponent<Rigidbody>();
            accelRatePerSecond = maxspeed / timeZeroToMax;
            forwardVelocity = 0f;

            CinemachineDollyCart TrainSpeed = TGVtrain.GetComponent<CinemachineDollyCart>();
            //TrainSpeed1 = TGVtrain.GetComponent<CinemachineDollyCart1>();
            Debug.Log(TrainSpeed.m_Speed);
        }

        // Update is called once per frame
        void Update()
        {
            //if (Input.GetKeyDown(KeyCode.Space)) {
            //rb.velocity *= 0.9f;  // it will slow down until it stops completly, if you multiply it by lets say 1.1f then it will accelerate
            //}
        }
    
        public void OnValueChanged(float value)
        {
            if (value >= 1f)
            {
                Brake.SetActive(true);
                BrakeHold.SetActive(true);
                BrakeNeutral.SetActive(true);
                EmergencyBrake.SetActive(true);
                Doorbutton.SetActive(false);
                //Doorbuttonvisible.SetActive(true);
                forwardVelocity += accelRatePerSecond * Time.deltaTime;
                forwardVelocity = Mathf.Min(forwardVelocity, maxspeed);
            }
            else
            {
                Brake.SetActive(true);
                BrakeHold.SetActive(true);
                BrakeNeutral.SetActive(true);
                EmergencyBrake.SetActive(true);
                Doorbutton.SetActive(true);
                //Doorbuttonvisible.SetActive(false);
                LateUpdate();
            }
    
            //TrainSpeed = Powerslider.value;
            //Debug.Log("Current Train Speed:" + TrainSpeed);

            if (Powerslider.value == 0f)
            {
                if (!trainAudioTriggered)
                {
                    TGVsounds.tgvnoises.PlayTGVAudioIdling();
                    trainAudioTriggered = true;
                }
            }
            else if (Powerslider.value >= 1f && Powerslider.value < 50f)
            {
                if (trainAudioTriggered)
                {
                    TGVsounds.tgvnoises.PlayTGVAudioAccelerate();
                    trainAudioTriggered = false;
                }
            }
            else
            {
                if (!trainAudioTriggered)
                {
                    TGVsounds.tgvnoises.PlayTGVAudioMoving();
                    trainAudioTriggered = true;
                }
            }
        }

        void LateUpdate()
        {
            rb.velocity = transform.forward * forwardVelocity;
        }
    }
}
