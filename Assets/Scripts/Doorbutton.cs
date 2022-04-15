using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class Doorbutton : MonoBehaviour
{
    public VideoClip[] Doorvideos;
    private VideoPlayer DoorVideoplayer;
    public Text DoorText;
    private int doorvideoClipIndex;
    private int doorcounter; 

    //Awake is called before Start
    private void Awake()
    {
        DoorVideoplayer = GetComponent<VideoPlayer>();
    }

    // Start is called before the first frame update
    void Start()
    {
        DoorVideoplayer.clip = Doorvideos[0];
    }

    public void WhenDoorbuttonIsClicked()
    {
        doorcounter++;
        if (doorcounter % 2 == 1)
        {
            DoorText.text = "Door (close)";
            Debug.Log("Door is opening." + doorcounter);
            DoorVideoplayer.clip = Doorvideos[0];
        }
        else
        {
            DoorText.text = "Door (open)";
            Debug.Log("Door is closing." + doorcounter);
            DoorVideoplayer.clip = Doorvideos[1];
        }

        DoorVideoplayer.Play();
        TGVsounds.tgvnoises.PlayDoorSound();
    }
}