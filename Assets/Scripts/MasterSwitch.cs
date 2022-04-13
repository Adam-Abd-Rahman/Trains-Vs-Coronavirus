using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MasterSwitch : MonoBehaviour
{
    public GameObject Pantographcontrol;
    //public GameObject Pantographcontrolvisible;
    public GameObject Pantographmode;
    //public GameObject Pantographmodevisible;
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
            //MasterSwitchsound.Stop();
        }
        else
        {
            MasterSwitchtext.text = "Master Switch (on)";
            //MasterSwitchsound.Play();
        }
    }

    public void WhenMasterSwitchIsActive()
    {
        if (Pantographcontrol != null)
        {
            bool isActive = Pantographcontrol.activeSelf;
            Pantographcontrol.SetActive(!isActive);
        }

        if (Pantographmode != null)
        {
            bool isActive = Pantographmode.activeSelf;
            Pantographmode.SetActive(!isActive);
        }

    }

    public void PlayMasterSwitchSound()
    {
        MasterSwitchaudiosource.clip = MasterSwitchsound;
        MasterSwitchaudiosource.Play();
    }

}
