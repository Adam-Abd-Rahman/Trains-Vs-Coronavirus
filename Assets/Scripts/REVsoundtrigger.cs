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

    public void OnTriggerEnter(Collider other)
    {
        PlayRev();
    }

    public void PlayRev()
    {
        TGVRevAudio.clip = Rev;
        TGVRevAudio.Play();
    }
}
