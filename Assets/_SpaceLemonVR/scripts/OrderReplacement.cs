using System.Collections;
using System.Collections.Generic;
using NewtonVR;
using UnityEngine;

public class OrderReplacement : MonoBehaviour
{
    [SerializeField]private RecieveBroadcast communicationReciever;
    [SerializeField]private GameObject box;
    [SerializeField]private GameObject panelToRemove;
    [SerializeField]private NVRButton button;
    [SerializeField] private float timeToWait;
    private float time;
    private bool buttonPressed;
    private bool boxArrive; //restore if you only ever want one box


    // Use this for initialization
    void Start()
    {

        time = 0;
       
        panelToRemove.SetActive(true);
        buttonPressed = false;
       // boxArrive = false; //restore if you only ever want one box

    }

    // Update is called once per frame
    void Update()
    {

        if (button.ButtonDown)
        {
            buttonPressed = true;
            gameObject.GetComponent<AudioSource>().Play();
            communicationReciever.increaseAudioRange();
        }
		//Debug.Log(buttonPressed + " " + communicationReciever.signal + " " + !boxArrive);
        if (buttonPressed && communicationReciever.signal && !boxArrive)
        {
            time += Time.deltaTime;
            if (time > timeToWait)
            {
                GameObject.Instantiate(box, panelToRemove.transform.position, panelToRemove.transform.rotation);
                panelToRemove.SetActive(false);
                // boxArrive = true; //restore if you only ever want one box

                //once box arrives if you do these steps again you can get another box
                buttonPressed = false;
                time = 0;
            }
        }
        else
        {
            time = 0;
        }
    }

    
}
