using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Serialization;

namespace Cinemachine
{
    public class GameScore : MonoBehaviour
    {
        public GameObject TGVtrain;
        private CinemachineDollyCart cinemachinedollycart;
        private CinemachineDollyCart1 cinemachinedollycart1;
        public Text ScoreText;
        public float Score = 5;
        //private float pointsDecreasedPerSecond;
        public Text GameOver;

        // Start is called before the first frame update
        void Start()
        {
            //Score = 5f;
            //pointsDecreasedPerSecond = 1.0f;
            TGVtrain = GameObject.Find("TGV");
            cinemachinedollycart = TGVtrain.GetComponent<CinemachineDollyCart>();
            cinemachinedollycart1 = TGVtrain.GetComponent<CinemachineDollyCart1>();

            GameOver.text = "";
            //Score = 5;
        }

        // Update is called once per frame
        void Update()
        {
            //Score -= pointsDecreasedPerSecond * Time.deltaTime;
            //ScoreText.text = Score.ToString("0");
            SetScoreText();
        }

        void SetScoreText()
        {
            ScoreText.text = "Game Score: " + Score;

            if (cinemachinedollycart.m_Position > 74.3f && cinemachinedollycart.m_Position < 75.1f)
            {
                Score = 504;
            }

            if (cinemachinedollycart.m_Position == 75.2f)
            {
                Score = 25200;
            }
        }

        private void OnTriggerEnter(Collider other)
        {

            if (cinemachinedollycart.m_Speed <= 5)
            {
                Score = 10;
                //Debug.Log("Success");

            }
            else
            {
                Score = 1;
                //Debug.Log("Not Success");

            }
        }

    }
}