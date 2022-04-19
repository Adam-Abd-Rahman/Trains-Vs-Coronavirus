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
        private float Score;
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
        }

        // Update is called once per frame
        void Update()
        {
            //Score -= pointsDecreasedPerSecond * Time.deltaTime;
            //ScoreText.text = Score.ToString("0");
            //SetScoreText();
        }

        public void SetScoreText(float Score)
        {
            ScoreText.text = "Game Score: " + Score;

            if (Score == 0)
            {
                GameOver.text = "Game Over!!!";
            }
        }

    }
}