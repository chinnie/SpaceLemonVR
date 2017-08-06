using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchboardLight : MonoBehaviour 
{
	private Renderer thisRend;

	public int timesActive;

	[SerializeField] private Color offCol;
	[SerializeField] private Color onCol;

	void Start()
	{
		thisRend = GetComponent<Renderer> ();
		thisRend.material.SetColor ("_EmissionColor", offCol);
	}

	public void TurnOn()
	{
		if (timesActive > 0 && onCol != thisRend.material.GetColor ("_EmissionColor"))
			thisRend.material.SetColor ("_EmissionColor", onCol);
	}

	public void Activate(bool active)
	{
		if (active) 
		{
			timesActive += 1;
			if (timesActive > 0 && onCol != thisRend.material.GetColor ("_EmissionColor"))
				thisRend.material.SetColor ("_EmissionColor", onCol);
		} 
		else 
		{
			timesActive -= 1;
			if(timesActive < 1 && offCol != thisRend.material.GetColor ("_EmissionColor"))
				thisRend.material.SetColor ("_EmissionColor", offCol);
		}
	}
}