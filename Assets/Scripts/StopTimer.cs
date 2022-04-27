using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Serialization;

namespace Cinemachine
{

    public class StopTimer : MonoBehaviour
    {
        public GameObject TGVtrain;
        private CinemachineDollyCart0 cinemachinedollycart;

        public GameObject CountdownTimer;

        // Start is called before the first frame update
        void Start()
        {
            TGVtrain = GameObject.Find("Engine_1_1");
            cinemachinedollycart = TGVtrain.GetComponent<CinemachineDollyCart0>();            
        }

        private void OnTriggerStay(Collider other)
        {

            if (cinemachinedollycart.m_Speed == 0)
            {
                CountdownTimer.SetActive(false);
            }            
        }
    }
}