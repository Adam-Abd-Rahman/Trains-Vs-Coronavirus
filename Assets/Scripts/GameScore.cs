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
        public Text GameOver;

        public GameObject CountdownTimer;

        // Start is called before the first frame update
        void Start()
        {
            TGVtrain = GameObject.Find("TGV");
            cinemachinedollycart = TGVtrain.GetComponent<CinemachineDollyCart>();
            cinemachinedollycart1 = TGVtrain.GetComponent<CinemachineDollyCart1>();

            GameOver.text = "";
        }

        public void SetScoreText(float Score)
        {
            ScoreText.text = "Game Score: " + Score;

            if (Score == 0)
            {
                GameOver.text = "Game Over!!!";
                cinemachinedollycart.m_Speed = 0;
                cinemachinedollycart1.m_Speed = 0;
                CountdownTimer.SetActive(false);
            }
        }

    }
}