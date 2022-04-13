using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Serialization;

namespace Cinemachine
{
    public class intersectioncontroller : MonoBehaviour
    {
        public GameObject TGVtrain;
        public CinemachineDollyCart path;
        public CinemachineDollyCart1 path1;
        public Slider intersectionslider;

        // Start is called before the first frame update
        void Start()
        {
            path = TGVtrain.GetComponent<CinemachineDollyCart>();
            path1 = TGVtrain.GetComponent<CinemachineDollyCart1>();
            ChangeDestination(0);
            intersectionslider.onValueChanged.AddListener(delegate { ValueChangeCheck(); });
        }
       
        public void ChangeDestination(int part)
        {
            Debug.Log(part);
            if (part == 0)
            {
                path.enabled = true;
                path1.enabled = false;
            }
            else
            {
                path.enabled = false;
                path1.enabled = true;
            }
        }

        public void ValueChangeCheck()
        {
            if (intersectionslider.value == 0f)
            {
                ChangeDestination(0);
            }
            else
            {
                ChangeDestination(1);
            }
        }
    }
}
