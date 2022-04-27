using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Serialization;

namespace Cinemachine
{

    public class StopTimerForParis : MonoBehaviour
    {
        public GameObject TGVtrain;
        private CinemachineDollyCart0 cinemachinedollycart;
        private CinemachineDollyCart3 cinemachinedollycart3;

        public GameObject CountdownTimer;

        // Start is called before the first frame update
        void Start()
        {
            TGVtrain = GameObject.Find("Engine_1_1");
            cinemachinedollycart = TGVtrain.GetComponent<CinemachineDollyCart0>();
            cinemachinedollycart3 = TGVtrain.GetComponent<CinemachineDollyCart3>();
        }

        private void OnTriggerStay(Collider other)
        {

            if (cinemachinedollycart.m_Speed == 0)
            {
                CountdownTimer.SetActive(false);
            }

            if (cinemachinedollycart3.m_Speed == 0)
            {
                CountdownTimer.SetActive(false);
            }
        }
    }
}