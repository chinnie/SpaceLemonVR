using System.Collections;
using System.Collections.Generic;
using NewtonVR;
using UnityEngine;

public class ToggleSound : MonoBehaviour
{
    [SerializeField] private AudioClip[] soundsToPlay;
    [SerializeField] private AudioSource speakers;
    [SerializeField] private NVRButton button;
    private bool buttonPressed;
    private int soundIndex;



    // Use this for initialization
    void Start()
    {
        buttonPressed = true;
        soundIndex = 0;
        //play sound
        speakers.clip = soundsToPlay[soundIndex];
        speakers.Play();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (button.ButtonDown)
        {
            gameObject.GetComponent<AudioSource>().Play();
        }

        if (button.ButtonDown && buttonPressed == false)
        {
            buttonPressed = true;
            //play sound
            speakers.clip = soundsToPlay[soundIndex];
            speakers.Play();
            speakers.volume = 1;
            


        } else if (button.ButtonDown && buttonPressed == true)
        {
            buttonPressed = false;
            //stop sound
            speakers.clip = soundsToPlay[soundIndex];
            speakers.Stop();
            speakers.volume = 0;
            if (soundIndex < soundsToPlay.Length - 1)
            {
                soundIndex += 1;
            }
            else
            {
                soundIndex = 0;
            }
        }
    }
}