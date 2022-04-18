using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Serialization;

namespace Cinemachine
{
    public class VACMA : MonoBehaviour
    {
        public GameObject VACMAtimer;

        public GameObject TGVtrain;
        private CinemachineDollyCart cinemachinedollycart;
        private CinemachineDollyCart1 cinemachinedollycart1;

        // Start is called before the first frame update
        void Start()
        {
            TGVtrain = GameObject.Find("TGV");
            cinemachinedollycart = TGVtrain.GetComponent<CinemachineDollyCart>();
            cinemachinedollycart1 = TGVtrain.GetComponent<CinemachineDollyCart1>();
        }

        // Update is called once per frame
        void Update()
        { 

            if (cinemachinedollycart.m_Speed >= 8)
            {
                VACMAtimer.SetActive(true); 
            }

            if (cinemachinedollycart1.m_Speed >= 8)
            {
                VACMAtimer.SetActive(true);
            }
       }
    }
}