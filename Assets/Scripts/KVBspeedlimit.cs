using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Serialization;

namespace Cinemachine
{

    public class KVBspeedlimit : MonoBehaviour
    {
        private float stop = 0f;

        public GameObject TGVEngine1;
        private CinemachineDollyCart0 PathForEngine1;
        private CinemachineDollyCart1 Path1ForEngine1;
        private CinemachineDollyCart2 Path2ForEngine1;
        private CinemachineDollyCart3 Path3ForEngine1;
        private CinemachineDollyCart4 Path4ForEngine1;
        
        public Slider brakeslider;

        public GameObject drivingpanel;
        private GameScore ScoreByPower;

        // Start is called before the first frame update
        void Start()
        {
            TGVEngine1 = GameObject.Find("Engine_1_1");
            PathForEngine1 = TGVEngine1.GetComponent<CinemachineDollyCart0>();
            Path1ForEngine1 = TGVEngine1.GetComponent<CinemachineDollyCart1>();
            Path2ForEngine1 = TGVEngine1.GetComponent<CinemachineDollyCart2>();
            Path3ForEngine1 = TGVEngine1.GetComponent<CinemachineDollyCart3>();
            Path4ForEngine1 = TGVEngine1.GetComponent<CinemachineDollyCart4>();
            ScoreByPower = drivingpanel.GetComponent<GameScore>();
        }

        public void OnTriggerStay(Collider other)
        {

            if (PathForEngine1.m_Speed >= 5)
            {
                brakeslider.value = 0;
                ScoreByPower.SetScoreText(stop);
            }

            if (Path1ForEngine1.m_Speed >= 5)
            {
                brakeslider.value = 0;
                ScoreByPower.SetScoreText(stop);
            }

            if (Path2ForEngine1.m_Speed >= 5)
            {
                brakeslider.value = 0;
                ScoreByPower.SetScoreText(stop);
            }

            if (Path3ForEngine1.m_Speed >= 5)
            {
                brakeslider.value = 0;
                ScoreByPower.SetScoreText(stop);
            }

            if (Path4ForEngine1.m_Speed >= 5)
            {
                brakeslider.value = 0;
                ScoreByPower.SetScoreText(stop);
            }
        }
    }
}
