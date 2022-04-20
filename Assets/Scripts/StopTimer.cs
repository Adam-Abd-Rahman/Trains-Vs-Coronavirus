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
        private CinemachineDollyCart cinemachinedollycart;

        public GameObject CountdownTimer;

        // Start is called before the first frame update
        void Start()
        {
            TGVtrain = GameObject.Find("TGV");
            cinemachinedollycart = TGVtrain.GetComponent<CinemachineDollyCart>();            
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