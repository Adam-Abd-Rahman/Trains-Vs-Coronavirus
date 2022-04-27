using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Serialization;

namespace Cinemachine
{

    public class Speedlimit4Strasbourg : MonoBehaviour
    {
        private float plusscore = 2758f;
        private float minusscore = 2513f;

        public GameObject KVBtext;

        public GameObject TGVEngine1;
        private CinemachineDollyCart1 Path1ForEngine1;
        
        public GameObject drivingpanel;
        private GameScore ScoreBySpeedLimit;

        // Start is called before the first frame update
        void Start()
        {
            TGVEngine1 = GameObject.Find("Engine_1_1");
            Path1ForEngine1 = TGVEngine1.GetComponent<CinemachineDollyCart1>();
            
            ScoreBySpeedLimit = drivingpanel.GetComponent<GameScore>();
        }
    
        private void OnTriggerStay(Collider other)
        {

            if (Path1ForEngine1.m_Speed <= 5)
            {
                ScoreBySpeedLimit.SetScoreText(plusscore);
                Debug.Log("To Strasbourg!");
            }
            else
            {
                ScoreBySpeedLimit.SetScoreText(minusscore);
            }

             KVBtext.GetComponent<Text>().text = "";
        }
    }
}
