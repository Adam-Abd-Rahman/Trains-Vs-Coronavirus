using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Horn : MonoBehaviour
{
    public AudioClip TGVhorn;

    AudioSource hornaudio;

    public static Horn tgvtrainhorn;

    // Start is called before the first frame update
    void Start()
    {
        tgvtrainhorn = this;
        hornaudio = GetComponent<AudioSource>();
    }

    public void PlayTGVAudioHorn()
    {
        hornaudio.clip = TGVhorn;
        hornaudio.Play();
    }

    public void StopTGVAudioHorn()
    {
        hornaudio.clip = TGVhorn;
        hornaudio.Stop();
    }
}
