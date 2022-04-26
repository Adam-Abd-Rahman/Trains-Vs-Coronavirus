using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Serialization;

namespace Cinemachine
{

    public class SpeedSelector : MonoBehaviour
    {
        public Slider SelectedSpeed;
        public Text SpeedSelectorvalue;
        public Slider Powerslider;

        public GameObject TGVEngine1;
        private CinemachineDollyCart PathForEngine1;
        private CinemachineDollyCart1 Path1ForEngine1;
        private CinemachineDollyCart2 Path2ForEngine1;
        private CinemachineDollyCart3 Path3ForEngine1;
        private CinemachineDollyCart4 Path4ForEngine1;

        public GameObject TGVEnginefrontbogie1;
        private CinemachineDollyCart PathForEnginefrontbogie1;
        private CinemachineDollyCart1 Path1ForEnginefrontbogie1;
        private CinemachineDollyCart2 Path2ForEnginefrontbogie1;
        private CinemachineDollyCart3 Path3ForEnginefrontbogie1;
        private CinemachineDollyCart4 Path4ForEnginefrontbogie1;

        public GameObject TGVEnginerearbogie1;
        private CinemachineDollyCart PathForEnginerearbogie1;
        private CinemachineDollyCart1 Path1ForEnginerearbogie1;
        private CinemachineDollyCart2 Path2ForEnginerearbogie1;
        private CinemachineDollyCart3 Path3ForEnginerearbogie1;
        private CinemachineDollyCart4 Path4ForEnginerearbogie1;

        public GameObject TGVCarriage1;
        private CinemachineDollyCart PathForCarriage1;
        private CinemachineDollyCart1 Path1ForCarriage1;
        private CinemachineDollyCart2 Path2ForCarriage1;
        private CinemachineDollyCart3 Path3ForCarriage1;
        private CinemachineDollyCart4 Path4ForCarriage1;

        public GameObject TGVMiddleCarriage;
        private CinemachineDollyCart PathForMiddleCarriage;
        private CinemachineDollyCart1 Path1ForMiddleCarriage;
        private CinemachineDollyCart2 Path2ForMiddleCarriage;
        private CinemachineDollyCart3 Path3ForMiddleCarriage;
        private CinemachineDollyCart4 Path4ForMiddleCarriage;

        public GameObject TGVCarriage2;
        private CinemachineDollyCart PathForCarriage2;
        private CinemachineDollyCart1 Path1ForCarriage2;
        private CinemachineDollyCart2 Path2ForCarriage2;
        private CinemachineDollyCart3 Path3ForCarriage2;
        private CinemachineDollyCart4 Path4ForCarriage2;

        public GameObject TGVEngine2;
        private CinemachineDollyCart PathForEngine2;
        private CinemachineDollyCart1 Path1ForEngine2;
        private CinemachineDollyCart2 Path2ForEngine2;
        private CinemachineDollyCart3 Path3ForEngine2;
        private CinemachineDollyCart4 Path4ForEngine2;

        // Start is called before the first frame update
        void Start()
        {
            SelectedSpeed.onValueChanged.AddListener((v) =>
            {
                SpeedSelectorvalue.text = v.ToString("0");
            });

            TGVEngine1 = GameObject.Find("Engine_1 1");
            PathForEngine1 = TGVEngine1.GetComponent<CinemachineDollyCart>();
            Path1ForEngine1 = TGVEngine1.GetComponent<CinemachineDollyCart1>();
            Path2ForEngine1 = TGVEngine1.GetComponent<CinemachineDollyCart2>();
            Path3ForEngine1 = TGVEngine1.GetComponent<CinemachineDollyCart3>();
            Path4ForEngine1 = TGVEngine1.GetComponent<CinemachineDollyCart4>();

            TGVEnginefrontbogie1 = GameObject.Find("Engine_1_front_bogie_and_wheel");
            PathForEnginefrontbogie1 = TGVEnginefrontbogie1.GetComponent<CinemachineDollyCart>();
            Path1ForEnginefrontbogie1 = TGVEnginefrontbogie1.GetComponent<CinemachineDollyCart1>();
            Path2ForEnginefrontbogie1 = TGVEnginefrontbogie1.GetComponent<CinemachineDollyCart2>();
            Path3ForEnginefrontbogie1 = TGVEnginefrontbogie1.GetComponent<CinemachineDollyCart3>();
            Path4ForEnginefrontbogie1 = TGVEnginefrontbogie1.GetComponent<CinemachineDollyCart4>();

            TGVEnginerearbogie1 = GameObject.Find("Engine_1_rear_bogie_and_wheel");
            PathForEnginerearbogie1 = TGVEnginerearbogie1.GetComponent<CinemachineDollyCart>();
            Path1ForEnginerearbogie1 = TGVEnginerearbogie1.GetComponent<CinemachineDollyCart1>();
            Path2ForEnginerearbogie1 = TGVEnginerearbogie1.GetComponent<CinemachineDollyCart2>();
            Path3ForEnginerearbogie1 = TGVEnginerearbogie1.GetComponent<CinemachineDollyCart3>();
            Path4ForEnginerearbogie1 = TGVEnginerearbogie1.GetComponent<CinemachineDollyCart4>();
            
            //PathForCarriage1 = TGVCarriage1.GetComponent<CinemachineDollyCart>();
            //Path1ForCarriage1 = TGVCarriage1.GetComponent<CinemachineDollyCart1>();
            //Path2ForCarriage1 = TGVCarriage1.GetComponent<CinemachineDollyCart2>();
            //Path3ForCarriage1 = TGVCarriage1.GetComponent<CinemachineDollyCart3>();
            //Path4ForCarriage1 = TGVCarriage1.GetComponent<CinemachineDollyCart4>();

            //PathForMiddleCarriage = TGVMiddleCarriage.GetComponent<CinemachineDollyCart>();
            //Path1ForMiddleCarriage = TGVMiddleCarriage.GetComponent<CinemachineDollyCart1>();
            //Path2ForMiddleCarriage = TGVMiddleCarriage.GetComponent<CinemachineDollyCart2>();
            //Path3ForMiddleCarriage = TGVMiddleCarriage.GetComponent<CinemachineDollyCart3>();
            //Path4ForMiddleCarriage = TGVMiddleCarriage.GetComponent<CinemachineDollyCart4>();

            //PathForCarriage2 = TGVCarriage2.GetComponent<CinemachineDollyCart>();
            //Path1ForCarriage2 = TGVCarriage2.GetComponent<CinemachineDollyCart1>();
            //Path2ForCarriage2 = TGVCarriage2.GetComponent<CinemachineDollyCart2>();
            //Path3ForCarriage2 = TGVCarriage2.GetComponent<CinemachineDollyCart3>();
            //Path4ForCarriage2 = TGVCarriage2.GetComponent<CinemachineDollyCart4>();

            //PathForEngine2 = TGVEngine2.GetComponent<CinemachineDollyCart>();
            //Path1ForEngine2 = TGVEngine2.GetComponent<CinemachineDollyCart1>();
            //Path2ForEngine2 = TGVEngine2.GetComponent<CinemachineDollyCart2>();
            //Path3ForEngine2 = TGVEngine2.GetComponent<CinemachineDollyCart3>();
            //Path4ForEngine2 = TGVEngine2.GetComponent<CinemachineDollyCart4>();
        }

        // Update is called once per frame
        void Update()
        {
            if (Powerslider.value >= 60f)
            {
                PathForEngine1.m_Speed = 60f + SelectedSpeed.value;
                Path1ForEngine1.m_Speed = 60f + SelectedSpeed.value;
                Path2ForEngine1.m_Speed = 60f + SelectedSpeed.value;
                Path3ForEngine1.m_Speed = 60f + SelectedSpeed.value;
                Path4ForEngine1.m_Speed = 60f + SelectedSpeed.value;

                PathForEnginefrontbogie1.m_Speed = 60f + SelectedSpeed.value;
                Path1ForEnginefrontbogie1.m_Speed = 60f + SelectedSpeed.value;
                Path2ForEnginefrontbogie1.m_Speed = 60f + SelectedSpeed.value;
                Path3ForEnginefrontbogie1.m_Speed = 60f + SelectedSpeed.value;
                Path4ForEnginefrontbogie1.m_Speed = 60f + SelectedSpeed.value;

                PathForEnginerearbogie1.m_Speed = 60f + SelectedSpeed.value;
                Path1ForEnginerearbogie1.m_Speed = 60f + SelectedSpeed.value;
                Path2ForEnginerearbogie1.m_Speed = 60f + SelectedSpeed.value;
                Path3ForEnginerearbogie1.m_Speed = 60f + SelectedSpeed.value;
                Path4ForEnginerearbogie1.m_Speed = 60f + SelectedSpeed.value;

                //PathForCarriage1.m_Speed = 60f + SelectedSpeed.value;
                //Path1ForCarriage1.m_Speed = 60f + SelectedSpeed.value;
                //Path2ForCarriage1.m_Speed = 60f + SelectedSpeed.value;
                //Path3ForCarriage1.m_Speed = 60f + SelectedSpeed.value;
                //Path4ForCarriage1.m_Speed = 60f + SelectedSpeed.value;

                //PathForMiddleCarriage.m_Speed = 60f + SelectedSpeed.value;
                //Path1ForMiddleCarriage.m_Speed = 60f + SelectedSpeed.value;
                //Path2ForMiddleCarriage.m_Speed = 60f + SelectedSpeed.value;
                //Path3ForMiddleCarriage.m_Speed = 60f + SelectedSpeed.value;
                //Path4ForMiddleCarriage.m_Speed = 60f + SelectedSpeed.value;

                //PathForCarriage2.m_Speed = 60f + SelectedSpeed.value; 
                //Path1ForCarriage2.m_Speed = 60f + SelectedSpeed.value;
                //Path2ForCarriage2.m_Speed = 60f + SelectedSpeed.value;
                //Path3ForCarriage2.m_Speed = 60f + SelectedSpeed.value;
                //Path4ForCarriage2.m_Speed = 60f + SelectedSpeed.value;

                //PathForEngine2.m_Speed = 60f + SelectedSpeed.value;
                //Path1ForEngine2.m_Speed = 60f + SelectedSpeed.value;
                //Path2ForEngine2.m_Speed = 60f + SelectedSpeed.value;
                //Path3ForEngine2.m_Speed = 60f + SelectedSpeed.value;
                //Path4ForEngine2.m_Speed = 60f + SelectedSpeed.value;
            }
        }
    }
}