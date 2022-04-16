using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Serialization;

namespace Cinemachine
{
    public class PantographMode : MonoBehaviour
    {
        private float error = 0f;

        public Slider Pantographmode;
        public Text PantographModeText;

        public GameObject drivingpanel;
        private GameScore ScoreByPower;

        // Start is called before the first frame update
        void Start()
        {
            drivingpanel = GameObject.Find("Canvas");
            ScoreByPower = drivingpanel.GetComponent<GameScore>();
        }

        public void WhenPantographModeIsActive(float value)
        {
            if (value == 0)
            {
                PantographModeText.text = "AC";
                //Debug.Log("Using AC power supply." + value);
            }
            else if (value == 1)
            {
                PantographModeText.text = "DC";
                //Debug.Log("Using DC power supply." + value);
            }
            else
            {
                PantographModeText.text = "LGV";
                //Debug.Log("Using LGV power supply." + value);
            }
        }

        private void OnTriggerEnter(Collider other)
        {

            if (Pantographmode.value > 0)
            {
                //ScoreByPower.SetScoreText(error);
                Debug.Log("fail");
            }
        }

    }
}
