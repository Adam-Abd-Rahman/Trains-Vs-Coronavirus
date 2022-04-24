using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Serialization;

namespace Cinemachine
{

    public class ACPowerForStrasbourg : MonoBehaviour
    {
        private float success = 2029f;
        private float error = 0f; 

        public Slider Pantographmode;

        public GameObject drivingpanel;
        private GameScore ScoreByPower;

        // Start is called before the first frame update
        void Start()
        {
            ScoreByPower = drivingpanel.GetComponent<GameScore>();
        }

        private void OnTriggerStay(Collider other)
        {
            if (Pantographmode.value > 0)
            {
                ScoreByPower.SetScoreText(error);
            }
            else
            {
                ScoreByPower.SetScoreText(success);
            }
        }
    }
}