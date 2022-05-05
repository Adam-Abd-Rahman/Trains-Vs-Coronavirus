using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Serialization;
using UnityEngine.SceneManagement;

namespace Cinemachine
{
    public class GameScore : MonoBehaviour
    {
        public GameObject TGVdrivingcab;
        private CinemachineDollyCart0 PathFordrivingcab;
        private CinemachineDollyCart1 Path1Fordrivingcab;
        private CinemachineDollyCart2 Path2Fordrivingcab;
        private CinemachineDollyCart3 Path3Fordrivingcab;
        private CinemachineDollyCart4 Path4Fordrivingcab;

        public GameObject TGVEngine1;
        private CinemachineDollyCart0 PathForEngine1;
        private CinemachineDollyCart1 Path1ForEngine1;
        private CinemachineDollyCart2 Path2ForEngine1;
        private CinemachineDollyCart3 Path3ForEngine1;
        private CinemachineDollyCart4 Path4ForEngine1;

        public GameObject TGVEnginefrontbogie1;
        private CinemachineDollyCart0 PathForEnginefrontbogie1;
        private CinemachineDollyCart1 Path1ForEnginefrontbogie1;
        private CinemachineDollyCart2 Path2ForEnginefrontbogie1;
        private CinemachineDollyCart3 Path3ForEnginefrontbogie1;
        private CinemachineDollyCart4 Path4ForEnginefrontbogie1;

        public GameObject TGVEnginerearbogie1;
        private CinemachineDollyCart0 PathForEnginerearbogie1;
        private CinemachineDollyCart1 Path1ForEnginerearbogie1;
        private CinemachineDollyCart2 Path2ForEnginerearbogie1;
        private CinemachineDollyCart3 Path3ForEnginerearbogie1;
        private CinemachineDollyCart4 Path4ForEnginerearbogie1;

        public Text ScoreText;
        public Text GameOver;

        public GameObject CountdownTimer;

        public Text ScoringTimer;

        private Scene scene;
        
        // Start is called before the first frame update
        void Start()
        {
            TGVdrivingcab = GameObject.Find("TGV");
            PathFordrivingcab = TGVdrivingcab.GetComponent<CinemachineDollyCart0>();
            Path1Fordrivingcab = TGVdrivingcab.GetComponent<CinemachineDollyCart1>();
            Path2Fordrivingcab = TGVdrivingcab.GetComponent<CinemachineDollyCart2>();
            Path3Fordrivingcab = TGVdrivingcab.GetComponent<CinemachineDollyCart3>();
            Path4Fordrivingcab = TGVdrivingcab.GetComponent<CinemachineDollyCart4>();

            TGVEngine1 = GameObject.Find("Engine_1_1");
            PathForEngine1 = TGVEngine1.GetComponent<CinemachineDollyCart0>();
            Path1ForEngine1 = TGVEngine1.GetComponent<CinemachineDollyCart1>();
            Path2ForEngine1 = TGVEngine1.GetComponent<CinemachineDollyCart2>();
            Path3ForEngine1 = TGVEngine1.GetComponent<CinemachineDollyCart3>();
            Path4ForEngine1 = TGVEngine1.GetComponent<CinemachineDollyCart4>();

            TGVEnginefrontbogie1 = GameObject.Find("Engine_1_front_bogie_and_wheel");
            PathForEnginefrontbogie1 = TGVEnginefrontbogie1.GetComponent<CinemachineDollyCart0>();
            Path1ForEnginefrontbogie1 = TGVEnginefrontbogie1.GetComponent<CinemachineDollyCart1>();
            Path2ForEnginefrontbogie1 = TGVEnginefrontbogie1.GetComponent<CinemachineDollyCart2>();
            Path3ForEnginefrontbogie1 = TGVEnginefrontbogie1.GetComponent<CinemachineDollyCart3>();
            Path4ForEnginefrontbogie1 = TGVEnginefrontbogie1.GetComponent<CinemachineDollyCart4>();

            TGVEnginerearbogie1 = GameObject.Find("Engine_1_rear_bogie_and_wheel");
            PathForEnginerearbogie1 = TGVEnginerearbogie1.GetComponent<CinemachineDollyCart0>();
            Path1ForEnginerearbogie1 = TGVEnginerearbogie1.GetComponent<CinemachineDollyCart1>();
            Path2ForEnginerearbogie1 = TGVEnginerearbogie1.GetComponent<CinemachineDollyCart2>();
            Path3ForEnginerearbogie1 = TGVEnginerearbogie1.GetComponent<CinemachineDollyCart3>();
            Path4ForEnginerearbogie1 = TGVEnginerearbogie1.GetComponent<CinemachineDollyCart4>();

            scene = SceneManager.GetActiveScene();

            GameOver.text = "";           
        }

        public void SetScoreText(float Score)
        {
            ScoreText.text = "Game Score: " + Score;
            ScoringTimer.text = "";

            if (Score == 0)
            {
                GameOver.text = "Game Over!!!";

                PathFordrivingcab.m_Speed = 0f;
                Path1Fordrivingcab.m_Speed = 0f;
                Path2Fordrivingcab.m_Speed = 0f;
                Path3Fordrivingcab.m_Speed = 0f;
                Path4Fordrivingcab.m_Speed = 0f;

                PathForEngine1.m_Speed = 0f;
                Path1ForEngine1.m_Speed = 0f;
                Path2ForEngine1.m_Speed = 0f;
                Path3ForEngine1.m_Speed = 0f;
                Path4ForEngine1.m_Speed = 0f;

                PathForEnginefrontbogie1.m_Speed = 0f;
                Path1ForEnginefrontbogie1.m_Speed = 0f;
                Path2ForEnginefrontbogie1.m_Speed = 0f;
                Path3ForEnginefrontbogie1.m_Speed = 0f;
                Path4ForEnginefrontbogie1.m_Speed = 0f;

                PathForEnginerearbogie1.m_Speed = 0f;
                Path1ForEnginerearbogie1.m_Speed = 0f;
                Path2ForEnginerearbogie1.m_Speed = 0f;
                Path3ForEnginerearbogie1.m_Speed = 0f;
                Path4ForEnginerearbogie1.m_Speed = 0f;

                CountdownTimer.SetActive(false);
                Application.LoadLevel(scene.name);
            }
        }

    }
}