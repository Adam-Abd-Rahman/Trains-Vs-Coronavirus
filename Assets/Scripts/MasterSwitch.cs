using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MasterSwitch : MonoBehaviour
{
    public GameObject Pantographcontrol;
    public GameObject Pantographcontrolvisible;
    public GameObject Pantographmode;
    public GameObject Pantographmodevisible;
    public Text MasterSwitchtext;
    private int masterswitchcounter = 0;

    AudioSource MasterSwitchaudiosource; 
    public AudioClip MasterSwitchsound;

    // Start is called before the first frame update
    void Start()
    {
        MasterSwitchaudiosource = GetComponentInChildren<AudioSource>();
    }

    public void MasterSwitchTextIsActive()
    {
        masterswitchcounter++;
        if (masterswitchcounter % 2 == 1)
        {
            MasterSwitchtext.text = "Master Switch (off)";
        }
        else
        {
            MasterSwitchtext.text = "Master Switch (on)";
        }
    }

    public void WhenMasterSwitchIsActive()
    {
        masterswitchcounter++;
        if (masterswitchcounter % 2 == 1)
        {
            Pantographcontrol.SetActive(false);
            //Pantographcontrolvisible.SetActive(true);
            Pantographmode.SetActive(false);
            //Pantographmodevisible.SetActive(true);
        }
        else
        {
            MasterSwitchtext.text = "Master Switch (on)";
            Pantographcontrol.SetActive(true);
            //Pantographcontrolvisible.SetActive(false);
            Pantographmode.SetActive(true);
            //Pantographmodevisible.SetActive(false);

        }

    }

    public void PlayMasterSwitchSound()
    {
        MasterSwitchaudiosource.clip = MasterSwitchsound;
        MasterSwitchaudiosource.Play();
    }

}
