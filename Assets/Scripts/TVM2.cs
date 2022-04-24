using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Serialization;

namespace Cinemachine
{

    public class TVM2 : MonoBehaviour
    {
        private float increasescore = 1559f;
        private float decreasescore = 0f;

        public Text TVMtext;

        public GameObject TGVEngine1;
        private CinemachineDollyCart4 Path4ForEngine1;

        public GameObject drivingpanel;
        private GameScore ScoreByTVM;

        public Slider brakeslider;

        // Start is called before the first frame update
        void Start()
        {
            TGVEngine1 = GameObject.Find("TGV");
            Path4ForEngine1 = TGVEngine1.GetComponent<CinemachineDollyCart4>();

            ScoreByTVM = drivingpanel.GetComponent<GameScore>();

            TVMtext.text = "";
        }
    
        private void OnTriggerStay(Collider other)
        {

            if (Path4ForEngine1.m_Speed <= 5)
            {
                ScoreByTVM.SetScoreText(increasescore);
                TVMtext.text = "10kmph";
                Debug.Log("220 mph");
            }
            else if (Path4ForEngine1.m_Speed > 5 && Path4ForEngine1.m_Speed < 10)
            {
                ScoreByTVM.SetScoreText(increasescore);
                TVMtext.text = "Stay below 10 kmph";
                Debug.Log("Stay below 220 mph");
            }
            else
            {
                ScoreByTVM.SetScoreText(decreasescore);
                brakeslider.value = 0;
            }
        }

        private void OnTriggerExit(Collider other)
        {
            TVMtext.text = "";
        }

    }

        
}
