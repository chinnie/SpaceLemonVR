using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchboardLight : MonoBehaviour 
{
	private Renderer thisRend;
	private Light thisLight;

	public int timesActive;

	[SerializeField] private Color offCol;
	[SerializeField] private Color onCol;

	void Start()
	{
		thisRend = GetComponent<Renderer> ();
		thisLight = GetComponentInChildren<Light> ();
		thisLight.color = offCol;
		thisRend.material.SetColor ("_EmissionColor", offCol);
	}

	public void TurnOn()
	{
		if (timesActive > 0 && onCol != thisRend.material.GetColor ("_EmissionColor"))
			thisRend.material.SetColor ("_EmissionColor", onCol);
	}

	public void Activate(bool active)
	{
		//turn on
		if (active) 
		{
			timesActive += 1;
			if (timesActive > 0 && onCol != thisRend.material.GetColor ("_EmissionColor")) 
			{
				thisRend.material.SetColor ("_EmissionColor", onCol);
				thisLight.color = onCol;
			}
		} 
		//turn off
		else 
		{
			timesActive -= 1;
			if (timesActive < 1 && offCol != thisRend.material.GetColor ("_EmissionColor")) 
			{
				thisRend.material.SetColor ("_EmissionColor", offCol);
				thisLight.color = offCol;
			}
		}
	}
}