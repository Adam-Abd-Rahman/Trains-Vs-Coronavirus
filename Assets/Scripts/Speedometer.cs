using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Serialization;

namespace Cinemachine
{

    public class Speedometer : MonoBehaviour
    {
        public GameObject TGVEngine1;
        private CinemachineDollyCart0 PathForEngine1;
        private CinemachineDollyCart1 Path1ForEngine1;
        private CinemachineDollyCart2 Path2ForEngine1;
        private CinemachineDollyCart3 Path3ForEngine1;
        private CinemachineDollyCart4 Path4ForEngine1;

        public Text speedLabel; // The label that displays the speed;

        // Start is called before the first frame update
        void Start()
        {
            TGVEngine1 = GameObject.Find("TGV");
            PathForEngine1 = TGVEngine1.GetComponent<CinemachineDollyCart0>();
            Path1ForEngine1 = TGVEngine1.GetComponent<CinemachineDollyCart1>();
            Path2ForEngine1 = TGVEngine1.GetComponent<CinemachineDollyCart2>();
            Path3ForEngine1 = TGVEngine1.GetComponent<CinemachineDollyCart3>();
            Path4ForEngine1 = TGVEngine1.GetComponent<CinemachineDollyCart4>();
        }

        // Update is called once per frame
        void Update()
        {
            speedLabel.text = "Speed: " + PathForEngine1.m_Speed + " km/h";
            speedLabel.text = "Speed: " + Path1ForEngine1.m_Speed + " km/h";
            speedLabel.text = "Speed: " + Path2ForEngine1.m_Speed + " km/h";
            speedLabel.text = "Speed: " + Path3ForEngine1.m_Speed + " km/h";
            speedLabel.text = "Speed: " + Path4ForEngine1.m_Speed + " km/h";
        }
    }
}