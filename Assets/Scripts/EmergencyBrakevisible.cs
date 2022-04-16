using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EmergencyBrakevisible : MonoBehaviour
{
        public Text EmergencyBraketext;
        private int EmergencyBrakecounter = 0;

        public Slider brakeslider;

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
            //EmergencyBrakeScore.SetScoreText(zeroscore);

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
