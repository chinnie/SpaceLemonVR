using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecieveBroadcast : MonoBehaviour {

    [SerializeField] private AudioSource backgroundStatic;
    [SerializeField] private AudioSource broadcastMessage;
    [SerializeField] private Vector3 sourceBroadcast;
    [SerializeField] private float sensativity = 1.0f; 



    // Use this for initialization
    void Start ()
    {

        backgroundStatic.volume = 1;
        broadcastMessage.volume = 0;


    }
	
	// Update is called once per frame
	void Update ()
	{

	    Vector3 facing = transform.up;
	    float amplitude =  Vector3.Dot(facing, sourceBroadcast); //if facing and sourceBroadcase in same direction will return 1

	    if (amplitude > 0)
	    {
	        broadcastMessage.volume = amplitude;
	        backgroundStatic.volume = 1 - amplitude;
	    }
	    else
	    {
            backgroundStatic.volume = 1;
            broadcastMessage.volume = 0;
        }
	}
}
