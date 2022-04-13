using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TGVsounds : MonoBehaviour
{
    public AudioClip TGVmoving;
    public AudioClip TGVidling;
    public AudioClip TGVaccelerating;
    public AudioClip TGVbraking;
    public AudioClip Rev;

    AudioSource TGVaudio;

    public static TGVsounds tgvnoises;

    // Start is called before the first frame update
    void Start()
    {
        tgvnoises = this;
        TGVaudio = GetComponent<AudioSource>();
    }

    public void PlayTGVAudioMoving()
    {
        TGVaudio.clip = TGVmoving;
        TGVaudio.Play();
    }

    public void PlayTGVAudioIdling()
    {
        TGVaudio.clip = TGVidling;
        TGVaudio.Play();
    }

    public void PlayTGVAudioAccelerate()
    {
        TGVaudio.clip = TGVaccelerating;
        TGVaudio.Play();
    }

    public void PlayTGVAudioBrake()
    {
        TGVaudio.clip = TGVbraking;
        TGVaudio.Play();
    }

    public void StopTGVAudioBrake()
    {
        TGVaudio.clip = TGVbraking;
        TGVaudio.Stop();
    }

    public void PlayRev()
    {
        TGVaudio.clip = Rev;
        TGVaudio.Play();
    }
}
