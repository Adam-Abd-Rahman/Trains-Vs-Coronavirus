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

        public GameObject TGVEngine1;
        private CinemachineDollyCart PathForEngine1;
        private CinemachineDollyCart1 Path1ForEngine1;
        private CinemachineDollyCart2 Path2ForEngine1;
        private CinemachineDollyCart3 Path3ForEngine1;
        private CinemachineDollyCart4 Path4ForEngine1;

        // Start is called before the first frame update
        void Start()
        {
            TGVEngine1 = GameObject.Find("Engine_1 1");
            PathForEngine1 = TGVEngine1.GetComponent<CinemachineDollyCart>();
            Path1ForEngine1 = TGVEngine1.GetComponent<CinemachineDollyCart1>();
            Path2ForEngine1 = TGVEngine1.GetComponent<CinemachineDollyCart2>();
            Path3ForEngine1 = TGVEngine1.GetComponent<CinemachineDollyCart3>();
            Path4ForEngine1 = TGVEngine1.GetComponent<CinemachineDollyCart4>();
        }

        // Update is called once per frame
        void Update()
        { 

            if (PathForEngine1.m_Speed >= 8)
            {
                VACMAtimer.SetActive(true); 
            }

            if (Path1ForEngine1.m_Speed >= 8)
            {
                VACMAtimer.SetActive(true);
            }

            if (Path2ForEngine1.m_Speed >= 8)
            {
                VACMAtimer.SetActive(true);
            }

            if (Path3ForEngine1.m_Speed >= 8)
            {
                VACMAtimer.SetActive(true);
            }

            if (Path4ForEngine1.m_Speed >= 8)
            {
                VACMAtimer.SetActive(true);
            }
            
        }
    }
}