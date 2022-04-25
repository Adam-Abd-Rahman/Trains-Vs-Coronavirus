using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Serialization;

namespace Cinemachine
{

    public class CountdownTimer : MonoBehaviour
    {
        [SerializeField] Text countdownText;

        public float Timerstarts;
        private float Second;
        private float Score;

        public Text ScoreText;
        public Text GameOver;

        public Text ScoringScoreText;

        // Start is called before the first frame update
        void Start()
        {
            Timerstarts = 50f;
            Second = 1f;
            Score = 1029f;

            GameOver.text = "";
        }

        // Update is called once per frame
        public void Update()
        {
            Timerstarts -= Second * Time.deltaTime;
            countdownText.text = Timerstarts.ToString("0");

            if (Timerstarts <= 0)
            {
                Timerstarts = 0;
                TimerScore();
            }

        }

        // 
        public void TimerScore()
        {
            Score -= Second* Time.deltaTime;
            ScoreText.text = "Game Score: " + (int)Score;
            ScoringScoreText.text = "";

            if (Score <= 0)
            {
                Score = 0;
                GameOver.text = "Game Over!!!";
            }
        }
    }
}