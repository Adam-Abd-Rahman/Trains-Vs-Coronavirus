using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Serialization;

namespace Cinemachine
{

    public class VACMASlider : MonoBehaviour
    {
        public GameObject VACMA;

        public GameObject TGVtrain;
        private CinemachineDollyCart cinemachinedollycart;
        private CinemachineDollyCart1 cinemachinedollycart1;

        public Slider VACMAslider;
        public Text VACMAText;

        // Start is called before the first frame update
        void Start()
        {
            TGVtrain = GameObject.Find("Engine_1");
            cinemachinedollycart = TGVtrain.GetComponent<CinemachineDollyCart>();
            cinemachinedollycart1 = TGVtrain.GetComponent<CinemachineDollyCart1>();
        }

        public void OnValueChanged(float value)
        {
            if (value == 0)
            {
                VACMAText.text = "Off";
                VACMA.SetActive(false);
                //Debug.Log("VACMA is off");
            }
            else
            {
                VACMAText.text = "On";
                VACMA.SetActive(true);
                //Debug.Log("VACMA is on");
            }
        }
    }
}
