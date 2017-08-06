using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecieveBroadcast : MonoBehaviour {

    [SerializeField] private AudioSource backgroundStatic;
    [SerializeField] private AudioSource broadcastMessage;
    [SerializeField] private Vector3 sourceBroadcast;
    [SerializeField] private float maxAudibleAngle;

    public Boolean signal;
    private float maxAudibleCos;



    // Use this for initialization
    void Start ()
    {

        backgroundStatic.volume = 1;
        broadcastMessage.volume = 0;
        signal = false;
        maxAudibleCos = Mathf.Cos(maxAudibleAngle * Mathf.Deg2Rad);
        

    }
	
	// Update is called once per frame
	void Update ()
	{

	    Vector3 facing = transform.up;
	    float amplitude =  Vector3.Dot(facing, sourceBroadcast); //if facing and sourceBroadcase in same direction will return 1
        //Debug.Log(amplitude);
	    amplitude = (amplitude - maxAudibleCos) / (1 - maxAudibleCos);

	    if (amplitude > 0)
	    {
	        broadcastMessage.volume = amplitude;
	        backgroundStatic.volume = 1 - amplitude;
	        if (amplitude > .87)
	        {
	            signal = true;
	        }
	        else
	        {
	            signal = false;
	        }
	       
                }
	    else
	    {
            backgroundStatic.volume = 1;
            broadcastMessage.volume = 0;
	        signal = false;
	    }
	}

   public void increaseAudioRange()
   {
       backgroundStatic.maxDistance = 1;
       broadcastMessage.maxDistance = 1;
   }
}
