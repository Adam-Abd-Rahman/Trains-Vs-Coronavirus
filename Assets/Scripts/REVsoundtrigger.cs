using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class REVsoundtrigger : MonoBehaviour
{
    public AudioClip Rev;

    AudioSource TGVRevAudio;

    // Start is called before the first frame update
    void Start()
    {
        TGVRevAudio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Revsound")
        {
            PlayRev();
        }
    }

    public void PlayRev()
    {
        TGVRevAudio.clip = Rev;
        TGVRevAudio.Play();
    }
}
