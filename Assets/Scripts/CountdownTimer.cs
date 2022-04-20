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

        public float Score;
        public float Timerstarts;
        private float Second;
        public Text GameOver;
        //public Text ScoreText;

        GameScore Scoring;
        [SerializeField] GameObject gamescoretimer;

        Speedlimit speedlimit;
        [SerializeField] GameObject TimerScoreBySpeedLimit;

        // Start is called before the first frame update
        void Start()
        {
            Timerstarts = 50f;
            Second = 1f;
            Score = 5f;

            Scoring = gamescoretimer.GetComponent<GameScore>();

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
            Scoring.ScoreText.text = "Game Score: " + (int)Score;

            if (Score <= 0)
            {
                Score = 0;
                GameOver.text = "Game Over!!!";
            }
            //Debug.Log(Score);
        }
    }
}