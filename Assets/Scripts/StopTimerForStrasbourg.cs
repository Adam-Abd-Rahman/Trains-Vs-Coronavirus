using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Serialization;

namespace Cinemachine
{

    public class StopTimerForStrasbourg : MonoBehaviour
    {
        public GameObject TGVtrain;
        private CinemachineDollyCart1 cinemachinedollycart1;

        public GameObject CountdownTimer;

        // Start is called before the first frame update
        void Start()
        {
            TGVtrain = GameObject.Find("Engine_1_1");
            cinemachinedollycart1 = TGVtrain.GetComponent<CinemachineDollyCart1>();
        }

        private void OnTriggerStay(Collider other)
        {

            if (cinemachinedollycart1.m_Speed == 0)
            {
                CountdownTimer.SetActive(false);
            }
        }
    }
}