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

        public void OnTriggerStay(Collider other)
        {

            KVBtext.GetComponent<Text>().text = "Upcoming Speed limit: 5 km/h";
        }
    }
}
