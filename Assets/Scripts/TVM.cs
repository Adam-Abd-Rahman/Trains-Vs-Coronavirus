using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Serialization;

namespace Cinemachine
{

    public class TVM : MonoBehaviour
    {
        private float increasescore = 100f;//1,559
        private float decreasescore = 1f;

        public GameObject TVMtext;

        public GameObject TGVtrain;
        private CinemachineDollyCart cinemachinedollycart;
        private CinemachineDollyCart1 cinemachinedollycart1;

        public GameObject drivingpanel;
        private GameScore ScoreByTVM;

        // Start is called before the first frame update
        void Start()
        {
            TGVtrain = GameObject.Find("TGV");
            cinemachinedollycart = TGVtrain.GetComponent<CinemachineDollyCart>();
            cinemachinedollycart1 = TGVtrain.GetComponent<CinemachineDollyCart1>();
    
            ScoreByTVM = drivingpanel.GetComponent<GameScore>();
        }
    
        private void OnTriggerStay(Collider other)
        {

            if (cinemachinedollycart.m_Speed <= 5)
            {
                ScoreByTVM.SetScoreText(increasescore);
            }
            else if (cinemachinedollycart.m_Speed > 5 && cinemachinedollycart.m_Speed < 10)
            {
                ScoreByTVM.SetScoreText(increasescore);
            }
            else
            {
                ScoreByTVM.SetScoreText(decreasescore);
            }

            if (cinemachinedollycart1.m_Speed <= 5)
            {
                ScoreByTVM.SetScoreText(increasescore);
            }
            else if (cinemachinedollycart1.m_Speed > 5 && cinemachinedollycart1.m_Speed < 10)
            {
                ScoreByTVM.SetScoreText(increasescore);
            }
            else
            {
                ScoreByTVM.SetScoreText(decreasescore);
            }

            TVMtext.GetComponent<Text>().text = "";
        }
    }
}
