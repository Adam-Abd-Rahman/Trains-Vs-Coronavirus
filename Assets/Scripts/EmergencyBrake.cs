using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Serialization;

namespace Cinemachine
{

    public class EmergencyBrake : MonoBehaviour
    {
        private float zeroscore = 0f;
        public GameObject CountdownTimer;

        public Text EmergencyBraketext;
        private int EmergencyBrakecounter = 0;

        public GameObject drivingpanel;
        private GameScore EmergencyBrakeScore;

        public Slider brakeslider;

        // Start is called before the first frame update
        void Start()
        {
            EmergencyBrakeScore = drivingpanel.GetComponent<GameScore>();
        }

        public void EmergencyBrakeTextIsActive()
        {
            EmergencyBrakecounter++;
            if (EmergencyBrakecounter % 2 == 1)
            {
                EmergencyBraketext.text = "Emergency Brake (on)";
            }
            else
            {
                EmergencyBraketext.text = "Emergency Brake (off)";
            }
        }
    
        public void ButtonClicked()
        {
            EmergencyBrakeScore.SetScoreText(zeroscore);
            CountdownTimer.SetActive(false);

            if (brakeslider.value == 3)
            {
                brakeslider.value = 3;
            }
            else
            {
                brakeslider.value = 0;
            }
        }
    }
}
