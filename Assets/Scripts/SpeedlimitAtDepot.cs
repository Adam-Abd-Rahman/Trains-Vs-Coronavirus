using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Serialization;

namespace Cinemachine
{

    public class SpeedlimitAtDepot : MonoBehaviour
    {
        public float plusscore = 1029f;
        public float minusscore = 0f;

        public GameObject KVBtext;

        public GameObject TGVEngine1;
        private CinemachineDollyCart PathForEngine1;

        public GameObject drivingpanel;
        private GameScore ScoreBySpeedLimit;

        // Start is called before the first frame update
        void Start()
        {
            TGVEngine1 = GameObject.Find("Engine_1 1");
            PathForEngine1 = TGVEngine1.GetComponent<CinemachineDollyCart>();
            
            ScoreBySpeedLimit = drivingpanel.GetComponent<GameScore>();
        }
    
        private void OnTriggerStay(Collider other)
        {
            if (PathForEngine1.m_Speed <= 5)
            {
                ScoreBySpeedLimit.SetScoreText(plusscore);
            }
            else
            {
                ScoreBySpeedLimit.SetScoreText(minusscore);
            }

            KVBtext.GetComponent<Text>().text = "";
        }
    }
}
