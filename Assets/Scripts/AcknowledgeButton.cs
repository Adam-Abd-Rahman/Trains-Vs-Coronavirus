using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Serialization;

namespace Cinemachine
{

    public class AcknowledgeButton : MonoBehaviour
    {
        TimerByVACMAandCrocodile TimerOfVACMAandCroc;
        [SerializeField] GameObject timer;

        // Start is called before the first frame update
        void Start()
        {
            TimerOfVACMAandCroc = timer.GetComponent<TimerByVACMAandCrocodile>();
        }

        public void ButtonClicked()
        {
            TimerOfVACMAandCroc.ActivateTimer = false;
            TimerOfVACMAandCroc.VACMAandCrocodiletimer.text = "";
        }
    }
}
