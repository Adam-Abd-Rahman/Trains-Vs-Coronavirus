using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Serialization;

namespace Cinemachine
{
    public class TimerByVACMAandCrocodile : MonoBehaviour
    {
        public Text VACMAandCrocodiletimer;
        private float fiveminutetimer;
        private float TimeDecreasedBySecond;

        private float zeropoints = 0f;

        public GameObject drivingpanel;
        private GameScore ScoreByVACMAandCrocodile;

        public Slider brakeslider;

        bool CancelTimer = false;

        // Start is called before the first frame update
        void Start()
        {
            fiveminutetimer = 5f;
            TimeDecreasedBySecond = 1f;

            ScoreByVACMAandCrocodile = drivingpanel.GetComponent<GameScore>();
        }

        // Update is called once per frame
        void Update()
        {
            VACMAandCrocodiletimer.text = fiveminutetimer.ToString("0");
            fiveminutetimer -= TimeDecreasedBySecond * Time.deltaTime;

            if (fiveminutetimer <= 0)
            {
               brakeslider.value = 0;
               fiveminutetimer = 0;

                ScoreByVACMAandCrocodile.SetScoreText(zeropoints);
            }
        }

        public void ButtonClicked()
        {
            CancelTimer = true; 
        }
    }
}
