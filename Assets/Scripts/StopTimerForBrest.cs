using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Serialization;

namespace Cinemachine
{

    public class StopTimerForBrest : MonoBehaviour
    {
        public GameObject TGVtrain;
        private CinemachineDollyCart4 cinemachinedollycart4;

        public GameObject CountdownTimer;

        // Start is called before the first frame update
        void Start()
        {
            TGVtrain = GameObject.Find("Engine_1_1");
            cinemachinedollycart4 = TGVtrain.GetComponent<CinemachineDollyCart4>();
        }

        private void OnTriggerStay(Collider other)
        {

            if (cinemachinedollycart4.m_Speed == 0)
            {
                CountdownTimer.SetActive(false);
            }
        }
    }
}