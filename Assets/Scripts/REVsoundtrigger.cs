using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class REVsoundtrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Revsound")
        {
            TGVsounds.tgvnoises.PlayRev();
        }
    }

    private void OnTriggerExit(Collider other)
    {

        if (other.tag == "Revsound")
        {
            TGVsounds.tgvnoises.PlayTGVAudioMoving();
        }
    }
}
