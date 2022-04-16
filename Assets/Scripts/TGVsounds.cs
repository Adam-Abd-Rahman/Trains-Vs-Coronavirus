using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TGVsounds : MonoBehaviour
{
        public AudioClip TGVidling;
        public AudioClip TGVbraking;
        public AudioClip doorsound;

        AudioSource TGVaudio;

        public static TGVsounds tgvnoises;

        // Start is called before the first frame update
        void Start()
        {
            tgvnoises = this;
            TGVaudio = GetComponent<AudioSource>();
        }

        public void PlayTGVAudioIdling()
        {
            TGVaudio.clip = TGVidling;
            TGVaudio.Play();
        }

        public void StopTGVAudioIdling()
        {
            TGVaudio.clip = TGVidling;
            TGVaudio.Stop();
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

        public void PlayDoorSound()
        {
            TGVaudio.clip = doorsound;
            TGVaudio.Play();
        }
}
