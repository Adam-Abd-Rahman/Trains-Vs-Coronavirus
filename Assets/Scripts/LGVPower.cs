using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Serialization;

namespace Cinemachine
{

    public class LGVPower : MonoBehaviour
    {
        private float success = 1529f; 
        private float error = 0f; 

        public Slider Pantographmode;
        //public Text PantographModeText;

        public GameObject drivingpanel;
        private GameScore ScoreByPower;

        // Start is called before the first frame update
        void Start()
        {
            ScoreByPower = drivingpanel.GetComponent<GameScore>();
        }

        private void OnTriggerStay(Collider other)
        {
            if (Pantographmode.value == 1)
            {
                //ScoreByPower.SetScoreText(success);
                //Debug.Log("LGV power on.");
            }
            else
            {
                //ScoreByPower.SetScoreText(error);
                //Debug.Log("fail.");
            }
        }
    }
}