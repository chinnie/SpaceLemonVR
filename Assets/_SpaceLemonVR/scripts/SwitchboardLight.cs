using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchboardLight : MonoBehaviour 
{
	private Renderer thisRend;

	public int timesActive;

	[SerializeField] private Material offMat;
	[SerializeField] private Material onMat;

	void Start()
	{
		thisRend = GetComponent<Renderer> ();
	}

	public void TurnOn()
	{
		if (timesActive > 0 && onMat != thisRend.material)
			thisRend.material = onMat;
	}

	public void Activate(bool active)
	{
		if (active) 
		{
			timesActive += 1;
			if (timesActive > 0 && onMat != thisRend.material)
				thisRend.material = onMat;
		} 
		else 
		{
			timesActive -= 1;
			if (timesActive < 1 && offMat != thisRend.material)
				thisRend.material = offMat;
		}
	}
}