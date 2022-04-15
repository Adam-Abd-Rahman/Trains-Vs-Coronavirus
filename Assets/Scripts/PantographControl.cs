using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class PantographControl : MonoBehaviour
{
    public Slider Pantographcontrol;
    public Text PantographControlText;
    public GameObject CircuitBreaker;
    //public GameObject CircuitBreakervisible;
    public GameObject Horn;
    //public GameObject Hornrvisible;
    public GameObject Pantographpanel;
    public VideoClip[] Pantographvideos;
    public VideoPlayer PantographVideoplayer;
    private int PantographvideoClipIndex;

    AudioSource Pantographaudiosource;
    public AudioClip Pantographsound;

    //Awake is called before Start
    private void Awake()
    {
        //PantographVideoplayer = Pantographpanel.GetComponent<VideoPlayer>();
    }

    // Start is called before the first frame update
    void Start()
    {
        Pantographaudiosource = GetComponentInChildren<AudioSource>();
        //PantographVideoplayer.clip = Pantographvideos[0];
    }

    public void WhenPantographControlIsActive(float value)
    {
        if (value == 0)
        {
            PantographControlText.text = "Lowered";
            CircuitBreaker.SetActive(false);
            //CircuitBreakervisible.SetActive(true);
            Horn.SetActive(false);
            //Hornrvisible.SetActive(true);
            //Debug.Log("Pantograph is lowered." + value);
        }
        else
        {
            PantographControlText.text = "Raised";
            CircuitBreaker.SetActive(true);
            //CircuitBreakervisible.SetActive(false);
            Horn.SetActive(true);
            //Hornrvisible.SetActive(false);
            //Debug.Log("Pantograph has raised." + value);
            TGVsounds.tgvnoises.PlayTGVAudioIdling();
        }
    
        //PantographvideoClipIndex++;
        //if (PantographvideoClipIndex % 2 == 1)
        //{
            //PantographVideoplayer.clip = Pantographvideos[0];
        //}
        //else
        //{
            //PantographVideoplayer.clip = Pantographvideos[1];
        //}

        PlayPantographSound();
        //PantographVideoplayer.Play();
    }

    public void PlayPantographSound()
    {
        Pantographaudiosource.clip = Pantographsound;
        Pantographaudiosource.Play();
    }
}
