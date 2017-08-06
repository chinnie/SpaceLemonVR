using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchboardLights : MonoBehaviour 
{
	private List<GameObject> lights = new List<GameObject>();
	private List<WireSocket> sockets = new List<WireSocket> ();
	private bool firstConfigActive;

	[Header("First Config")]
	[SerializeField] private Vector2 firstConfig;	//socket/socket
	[SerializeField] private List<GameObject> firstConfigLights = new List<GameObject>();

	[Header("Second Config")]
	[SerializeField] private Vector2 secondConfig;	//socket/socket
	[SerializeField] private List<GameObject> secondConfigLights = new List<GameObject>();

	[Header("Third Config")]
	[SerializeField] private Vector2 thirdConfig;	//socket/socket
	[SerializeField] private List<GameObject> thirdConfigLights = new List<GameObject>();

	void Start()
	{
		for (int i = 0; i < transform.childCount; i++) 
			lights.Add (transform.GetChild (i).gameObject);

		Transform t = GameObject.Find ("WireSockets").transform;
		for (int i = 0; i < t.childCount; i++)
			sockets.Add (t.GetChild (i).GetComponent<WireSocket>());
	}

	public void UpdateSwitchboardLights()
	{		
		if (0 == sockets.Count)
			return;

		CheckFirstConfig ();
	}

	private void CheckFirstConfig()
	{
		//a socket is empty
		if (null == sockets [(int)firstConfig.x].currentWire || null == sockets [(int)firstConfig.y].currentWire) 
		{
			if (firstConfigActive)
				FirstConfigOff ();
			
			return;
		} 
		//sockets are full
		else if (sockets [(int)firstConfig.x].currentWire.ID == sockets [(int)firstConfig.y].currentWire.ID) 
		{
			firstConfigActive = true;
			foreach (GameObject l in lights) 
			{
				if (firstConfigLights.Contains (l))
					l.SetActive (true);
				else
					l.SetActive (false);
			}
		} 
		//sockets are wrong
		else if (firstConfigActive)
			FirstConfigOff ();
	}

	private void FirstConfigOff()
	{
		firstConfigActive = false;
		foreach (GameObject l in lights) 
			l.SetActive (true);
	}
}