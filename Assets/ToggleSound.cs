using System.Collections;
using System.Collections.Generic;
using NewtonVR;
using UnityEngine;

public class ToggleSound : MonoBehaviour
{
    [SerializeField] private AudioClip soundToPlay;
    [SerializeField] private AudioSource speakers;
    [SerializeField] private NVRButton button;
    private bool buttonPressed;



    // Use this for initialization
    void Start()
    {
        buttonPressed = true;
        //play sound
        speakers.clip = soundToPlay;
        speakers.Play();
    }

    // Update is called once per frame
    void Update()
    {

        if (button.ButtonDown && buttonPressed == false)
        {
            buttonPressed = true;
            //play sound
            speakers.clip = soundToPlay;
            speakers.Play();
            speakers.volume = 1;


        } else if (button.ButtonDown && buttonPressed == true)
        {
            buttonPressed = false;
            //stop sound
            speakers.clip = soundToPlay;
            speakers.Stop();
            speakers.volume = 0;
        }
    }
}