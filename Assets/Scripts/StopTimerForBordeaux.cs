using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Serialization;

namespace Cinemachine
{

    public class StopTimerForBordeaux : MonoBehaviour
    {
        public GameObject TGVtrain;
        private CinemachineDollyCart2 cinemachinedollycart2;

        public GameObject CountdownTimer;

        // Start is called before the first frame update
        void Start()
        {
            TGVtrain = GameObject.Find("Engine_1_1");
            cinemachinedollycart2 = TGVtrain.GetComponent<CinemachineDollyCart2>();
        }

        private void OnTriggerStay(Collider other)
        {

            if (cinemachinedollycart2.m_Speed == 0)
            {
                CountdownTimer.SetActive(false);
            }
        }
    }
}