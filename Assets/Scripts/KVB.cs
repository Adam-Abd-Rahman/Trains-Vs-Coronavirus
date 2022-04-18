using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Serialization;

namespace Cinemachine
{
    public class KVB : MonoBehaviour
    {
        public GameObject KVBtext;

        public GameObject TGVtrain;
        private CinemachineDollyCart cinemachinedollycart;
        private CinemachineDollyCart1 cinemachinedollycart1;

        public Slider brakeslider;

        // Start is called before the first frame update
        void Start()
        {
            TGVtrain = GameObject.Find("TGV");
            cinemachinedollycart = TGVtrain.GetComponent<CinemachineDollyCart>();
            cinemachinedollycart1 = TGVtrain.GetComponent<CinemachineDollyCart1>();
        }

        public void OnTriggerStay(Collider other)
        {
            //KVBtext5.text = "Upcoming Speed limit: 5 km/h";
            KVBtext.GetComponent<Text>().text = "Upcoming Speed limit: 5 km/h";

            if (cinemachinedollycart.m_Speed >= 5)
            {
                brakeslider.value = 0;
            }
    
            if (cinemachinedollycart1.m_Speed >= 5)
            {
                brakeslider.value = 0;
            }
        }
    }
}
