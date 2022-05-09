using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Serialization;

namespace Cinemachine
{

    public class Speedlimit : MonoBehaviour
    {
        private float plusscore = 30f;
        private float minusscore = 0f;
        private float plusscore1 = 1009f;
        private float minusscore1 = 974f;

        public GameObject TGVEngine1;
        private CinemachineDollyCart0 PathForEngine1;
        private CinemachineDollyCart1 Path1ForEngine1;

        public GameObject drivingpanel;
        private GameScore ScoreBySpeedLimit;

        // Start is called before the first frame update
        void Start()
        {
            TGVEngine1 = GameObject.Find("TGV");
            PathForEngine1 = TGVEngine1.GetComponent<CinemachineDollyCart0>();
            Path1ForEngine1 = TGVEngine1.GetComponent<CinemachineDollyCart1>();

            ScoreBySpeedLimit = drivingpanel.GetComponent<GameScore>();
        }
    
        private void OnTriggerStay(Collider other)
        {
            if (PathForEngine1.m_Speed <= 5)
            {
                //ScoreBySpeedLimit.SetScoreText(plusscore);
                Debug.Log("30 (at depot)");
            }
            else
            {
                //ScoreBySpeedLimit.SetScoreText(minusscore);
                Debug.Log("0 (at depot)");
            }

            if (Path1ForEngine1.m_Speed <= 5)
            {
                ScoreBySpeedLimit.SetScoreText(plusscore1);
                Debug.Log("1009 (to Strasbourg)");
            }
            else
            {
                ScoreBySpeedLimit.SetScoreText(minusscore1);
                Debug.Log("974 (to Strasbourg)");
            }
        }
    }
}
