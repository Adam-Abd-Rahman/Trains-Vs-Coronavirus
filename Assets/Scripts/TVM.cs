using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Serialization;

namespace Cinemachine
{

    public class TVM : MonoBehaviour
    {
        private float increasescore = 1539f;
        private float decreasescore = 0f;

        public Text TVMtext;

        public GameObject TGVEngine1;
        private CinemachineDollyCart1 Path1ForEngine1;

        public GameObject drivingpanel;
        private GameScore ScoreByTVM;

        public Slider brakeslider;

        // Start is called before the first frame update
        void Start()
        {
            TGVEngine1 = GameObject.Find("Engine_1_1");
            Path1ForEngine1 = TGVEngine1.GetComponent<CinemachineDollyCart1>();

            ScoreByTVM = drivingpanel.GetComponent<GameScore>();

            TVMtext.text = "";
        }
    
        private void OnTriggerStay(Collider other)
        {

            if (Path1ForEngine1.m_Speed <= 5)
            {
                ScoreByTVM.SetScoreText(increasescore); 
                TVMtext.text = "10kmph";
                Debug.Log("1539 (TVM to Strasbourg)");
            }
            else if (Path1ForEngine1.m_Speed > 5 && Path1ForEngine1.m_Speed < 10)
            {
                ScoreByTVM.SetScoreText(increasescore);
                TVMtext.text = "Stay below 10 kmph";
                Debug.Log("1539 (TVM to Strasbourg)");
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