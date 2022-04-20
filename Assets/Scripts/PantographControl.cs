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
    //public GameObject Hornvisible;

    AudioSource Pantographaudiosource;
    public AudioClip Pantographsound;

    // Start is called before the first frame update
    void Start()
    {
        Pantographaudiosource = GetComponentInChildren<AudioSource>();
    }

    public void WhenPantographControlIsActive(float value)
    {
        if (value == 0)
        {
            PantographControlText.text = "Lowered";
            CircuitBreaker.SetActive(false);
            //CircuitBreakervisible.SetActive(true);
            Horn.SetActive(false);
            //Hornvisible.SetActive(true);
            //Debug.Log("Pantograph is lowered." + value);
        }
        else
        {
            PantographControlText.text = "Raised";
            CircuitBreaker.SetActive(true);
            //CircuitBreakervisible.SetActive(false);
            Horn.SetActive(true);
            //Hornvisible.SetActive(false);
            //Debug.Log("Pantograph has raised." + value);
        }

        PlayPantographSound();
    }

    public void PlayPantographSound()
    {
        Pantographaudiosource.clip = Pantographsound;
        Pantographaudiosource.Play();
    }
}
