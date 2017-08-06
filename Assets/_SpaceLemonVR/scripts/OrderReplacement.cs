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


    // Use this for initialization
    void Start()
    {

        time = 0;
        box.SetActive(false);
        panelToRemove.SetActive(true);
        buttonPressed = false;

    }

    // Update is called once per frame
    void Update()
    {

        if (button.ButtonDown)
        {
            buttonPressed = true;
        }
        if (buttonPressed && communicationReciever.signal)
        {
            time += Time.deltaTime;
            if (time > timeToWait)
            {
                box.SetActive(true);
                panelToRemove.SetActive(false);
            }
        }
        else
        {
            time = 0;
        }
    }

    
}
