using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchboardLights : MonoBehaviour 
{
	public void CheckConfig(int wireID, int socketID, bool attaching)
	{
		if (attaching) 
		{
			Debug.Log ("attach");
		} 
		else 
		{
			Debug.Log ("detach");
		}
	}
}