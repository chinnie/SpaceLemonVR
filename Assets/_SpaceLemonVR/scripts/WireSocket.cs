using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WireSocket : MonoBehaviour 
{
	//public int ID;
	public WireEnd currentWire;

	[HideInInspector] public ParticleSystem sparks;

	void Awake()
	{
		sparks = GetComponentInChildren<ParticleSystem> ();
	}
}