using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Serialization;

namespace Cinemachine
{

    public class Speedlimit4Bordeaux : MonoBehaviour
    {
        private float plusscore = 3487f;
        private float minusscore = 3242f;

        public GameObject KVBtext;

        public GameObject TGVEngine1;
        private CinemachineDollyCart2 Path2ForEngine1;

        public GameObject drivingpanel;
        private GameScore ScoreBySpeedLimit;

        // Start is called before the first frame update
        void Start()
        {
            TGVEngine1 = GameObject.Find("Engine_1_1");
            Path2ForEngine1 = TGVEngine1.GetComponent<CinemachineDollyCart2>();
            
            ScoreBySpeedLimit = drivingpanel.GetComponent<GameScore>();
        }
    
        private void OnTriggerStay(Collider other)
        {

            if (Path2ForEngine1.m_Speed <= 5)
            {
                ScoreBySpeedLimit.SetScoreText(plusscore);
                Debug.Log("To Bordeaux!");
            }
            else
            {
                ScoreBySpeedLimit.SetScoreText(minusscore);
            }

             KVBtext.GetComponent<Text>().text = "";
        }
    }
}
