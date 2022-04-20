using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Serialization;

namespace Cinemachine
{

    public class Crocodile : MonoBehaviour
    {
        public GameObject Crocodiletimer;

        public GameObject TGVtrain;
        private CinemachineDollyCart cinemachinedollycart;
        private CinemachineDollyCart1 cinemachinedollycart1;

        public AudioClip Croc;

        AudioSource TGVCrocAudio;

        // Start is called before the first frame update
        void Start()
        {
            TGVtrain = GameObject.Find("TGV");
            cinemachinedollycart = TGVtrain.GetComponent<CinemachineDollyCart>();
            cinemachinedollycart1 = TGVtrain.GetComponent<CinemachineDollyCart1>();

            TGVCrocAudio = GetComponent<AudioSource>();
        }

        public void OnTriggerEnter(Collider other)
        {
            TGVCrocAudio.clip = Croc;
            TGVCrocAudio.Play();

            if (cinemachinedollycart.m_Speed >= 1)
            {
                Crocodiletimer.SetActive(true);
            }
        }
    }
}
