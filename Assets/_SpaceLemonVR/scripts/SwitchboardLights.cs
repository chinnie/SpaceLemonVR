using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchboardLights : MonoBehaviour 
{
	private List<SwitchboardLight> lights = new List<SwitchboardLight>();
	//private List<SwitchboardLight> lightsToTurnOff = new List<SwitchboardLight>();
	//private List<SwitchboardLight> lightsToTurnOn = new List<SwitchboardLight>();
	private List<WireSocket> sockets = new List<WireSocket> ();
	private bool firstConfigActive;
	private bool secondConfigActive;
	private bool thirdConfigActive;
	private bool fourthConfigActive;
	private bool fifthConfigActive;
	private bool sixthConfigActive;
	private bool seventhConfigActive;
	private bool eighthConfigActive;
	private bool ninthConfigActive;

	[Header("First Config")]
	[SerializeField] private Vector2 firstConfig;	//socket/socket
	[SerializeField] private List<SwitchboardLight> firstConfigLights = new List<SwitchboardLight>();

	[Header("Second Config")]
	[SerializeField] private Vector2 secondConfig;	//socket/socket
	[SerializeField] private List<SwitchboardLight> secondConfigLights = new List<SwitchboardLight>();

	[Header("Third Config")]
	[SerializeField] private Vector2 thirdConfig;	//socket/socket
	[SerializeField] private List<SwitchboardLight> thirdConfigLights = new List<SwitchboardLight>();

	[Header("Fourth Config")]
	[SerializeField] private Vector2 fourthConfig;	//socket/socket
	[SerializeField] private List<SwitchboardLight> fourthConfigLights = new List<SwitchboardLight>();

	[Header("Fifth Config")]
	[SerializeField] private Vector2 fifthConfig;	//socket/socket
	[SerializeField] private List<SwitchboardLight> fifthConfigLights = new List<SwitchboardLight>();

	[Header("Sixth Config")]
	[SerializeField] private Vector2 sixthConfig;	//socket/socket
	[SerializeField] private List<SwitchboardLight> sixthConfigLights = new List<SwitchboardLight>();

	[Header("Seventh Config")]
	[SerializeField] private Vector2 seventhConfig;	//socket/socket
	[SerializeField] private List<SwitchboardLight> seventhConfigLights = new List<SwitchboardLight>();

	[Header("Eighth Config")]
	[SerializeField] private Vector2 eighthConfig;	//socket/socket
	[SerializeField] private List<SwitchboardLight> eighthConfigLights = new List<SwitchboardLight>();

	[Header("Ninth Config")]
	[SerializeField] private Vector2 ninthConfig;	//socket/socket
	[SerializeField] private List<SwitchboardLight> ninthConfigLights = new List<SwitchboardLight>();

	void Start()
	{
		for (int i = 0; i < transform.childCount; i++) 
			lights.Add (transform.GetChild (i).GetComponent<SwitchboardLight>());

		Transform t = GameObject.Find ("WireSockets").transform;
		for (int i = 0; i < t.childCount; i++)
			sockets.Add (t.GetChild (i).GetComponent<WireSocket>());
	}

	public void UpdateSwitchboardLights()
	{		
		if (0 == sockets.Count)
			return;

		CheckFirstConfig ();
		CheckSecondConfig ();
		CheckThirdConfig ();
		CheckFourthConfig ();
		CheckFifthConfig ();
		CheckSixthConfig ();
		CheckSeventhConfig ();
		CheckEighthConfig ();
		CheckNinthConfig ();
		/*
		foreach (SwitchboardLight li in lightsToTurnOn)
			li.Activate (true);

		foreach (SwitchboardLight lig in lightsToTurnOff)
			lig.Activate (false);

		lightsToTurnOn.Clear ();
		lightsToTurnOff.Clear ();
		*/
	}

	private void CheckFirstConfig()
	{
		//a socket is empty
		if (null == sockets [(int)firstConfig.x].currentWire || null == sockets [(int)firstConfig.y].currentWire) 
		{
			if (firstConfigActive)
				FirstConfigOff ();
		} 
		//sockets are full
		else if (sockets [(int)firstConfig.x].currentWire.ID == sockets [(int)firstConfig.y].currentWire.ID) 
		{
			foreach (SwitchboardLight l in firstConfigLights) 
			{				
				if (!firstConfigActive) 
					l.Activate (true);

				else
					l.TurnOn ();
			}
			firstConfigActive = true;
		} 
		//sockets are wrong
		else if (firstConfigActive)
			FirstConfigOff ();
	}

	private void CheckSecondConfig()
	{
		//a socket is empty
		if (null == sockets [(int)secondConfig.x].currentWire || null == sockets [(int)secondConfig.y].currentWire) 
		{
			if (secondConfigActive)
				SecondConfigOff ();
		} 
		//sockets are full
		else if (sockets [(int)secondConfig.x].currentWire.ID == sockets [(int)secondConfig.y].currentWire.ID) 
		{
			foreach (SwitchboardLight l in secondConfigLights) 
			{
				if (!secondConfigActive) 
					l.Activate (true);

				else
					l.TurnOn ();
			}
			secondConfigActive = true;
		} 
		//sockets are wrong
		else if (secondConfigActive)
			SecondConfigOff ();
	}

	private void CheckThirdConfig()
	{
		//a socket is empty
		if (null == sockets [(int)thirdConfig.x].currentWire || null == sockets [(int)thirdConfig.y].currentWire) 
		{
			if (thirdConfigActive)
				ThirdConfigOff ();
		} 
		//sockets are full
		else if (sockets [(int)thirdConfig.x].currentWire.ID == sockets [(int)thirdConfig.y].currentWire.ID) 
		{
			foreach (SwitchboardLight l in thirdConfigLights) 
			{
				if (!thirdConfigActive) 
					l.Activate (true);

				else
					l.TurnOn ();
			}
			thirdConfigActive = true;
		} 
		//sockets are wrong
		else if (thirdConfigActive)
			ThirdConfigOff ();
	}

	private void CheckFourthConfig()
	{
		//a socket is empty
		if (null == sockets [(int)fourthConfig.x].currentWire || null == sockets [(int)fourthConfig.y].currentWire) 
		{
			if (fourthConfigActive)
				FourthConfigOff ();
		} 
		//sockets are full
		else if (sockets [(int)fourthConfig.x].currentWire.ID == sockets [(int)fourthConfig.y].currentWire.ID) 
		{
			foreach (SwitchboardLight l in fourthConfigLights) 
			{
				if (!fourthConfigActive) 
					l.Activate (true);
 
				else
					l.TurnOn ();
			}
			fourthConfigActive = true;
		} 
		//sockets are wrong
		else if (fourthConfigActive)
			FourthConfigOff ();
	}

	private void CheckFifthConfig()
	{
		//a socket is empty
		if (null == sockets [(int)fifthConfig.x].currentWire || null == sockets [(int)fifthConfig.y].currentWire) 
		{
			if (fifthConfigActive)
				FifthConfigOff ();
		} 
		//sockets are full
		else if (sockets [(int)fifthConfig.x].currentWire.ID == sockets [(int)fifthConfig.y].currentWire.ID) 
		{
			foreach (SwitchboardLight l in fifthConfigLights) 
			{
				if (!fifthConfigActive) 
					l.Activate (true);

				else
					l.TurnOn ();
			}
			fifthConfigActive = true;
		} 
		//sockets are wrong
		else if (fifthConfigActive)
			FifthConfigOff ();
	}

	private void CheckSixthConfig()
	{
		//a socket is empty
		if (null == sockets [(int)sixthConfig.x].currentWire || null == sockets [(int)sixthConfig.y].currentWire) 
		{
			if (sixthConfigActive)
				SixthConfigOff ();
		} 
		//sockets are full
		else if (sockets [(int)sixthConfig.x].currentWire.ID == sockets [(int)sixthConfig.y].currentWire.ID) 
		{
			foreach (SwitchboardLight l in sixthConfigLights) 
			{
				if (!sixthConfigActive) 
					l.Activate (true);

				else
					l.TurnOn ();
			}
			sixthConfigActive = true;
		} 
		//sockets are wrong
		else if (sixthConfigActive)
			SixthConfigOff ();
	}

	private void CheckSeventhConfig()
	{
		//a socket is empty
		if (null == sockets [(int)seventhConfig.x].currentWire || null == sockets [(int)seventhConfig.y].currentWire) 
		{
			if (seventhConfigActive)
				SeventhConfigOff ();

			return;
		} 
		//sockets are full
		else if (sockets [(int)seventhConfig.x].currentWire.ID == sockets [(int)seventhConfig.y].currentWire.ID) 
		{
			foreach (SwitchboardLight l in seventhConfigLights) 
			{
				if (!seventhConfigActive) 
					l.Activate (true);

				else
					l.TurnOn ();
			}
			seventhConfigActive = true;
		} 
		//sockets are wrong
		else if (seventhConfigActive)
			SeventhConfigOff ();
	}

	private void CheckEighthConfig()
	{
		//a socket is empty
		if (null == sockets [(int)eighthConfig.x].currentWire || null == sockets [(int)eighthConfig.y].currentWire) 
		{
			if (eighthConfigActive)
				EighthConfigOff ();
		} 
		//sockets are full
		else if (sockets [(int)eighthConfig.x].currentWire.ID == sockets [(int)eighthConfig.y].currentWire.ID) 
		{
			foreach (SwitchboardLight l in eighthConfigLights) 
			{
				if (!eighthConfigActive) 
					l.Activate (true);

				else
					l.TurnOn ();
			}
			eighthConfigActive = true;
		} 
		//sockets are wrong
		else if (eighthConfigActive)
			EighthConfigOff ();
	}

	private void CheckNinthConfig()
	{
		//a socket is empty
		if (null == sockets [(int)ninthConfig.x].currentWire || null == sockets [(int)ninthConfig.y].currentWire) 
		{
			if (ninthConfigActive)
				NinthConfigOff ();
		} 
		//sockets are full
		else if (sockets [(int)ninthConfig.x].currentWire.ID == sockets [(int)ninthConfig.y].currentWire.ID) 
		{
			foreach (SwitchboardLight l in ninthConfigLights) 
			{
				if (!ninthConfigActive) 
					l.Activate (true);

				else
					l.TurnOn ();
			}
			ninthConfigActive = true;
		} 
		//sockets are wrong
		else if (ninthConfigActive)
			NinthConfigOff ();
	}

	private void FirstConfigOff()
	{
		firstConfigActive = false;
		foreach (SwitchboardLight l in firstConfigLights)
			l.Activate (false);
			//lightsToTurnOff.Add(l);
	}

	private void SecondConfigOff()
	{
		secondConfigActive = false;
		foreach (SwitchboardLight l in secondConfigLights)
			l.Activate (false);
			//lightsToTurnOff.Add(l);
	}

	private void ThirdConfigOff()
	{
		thirdConfigActive = false;
		foreach (SwitchboardLight l in thirdConfigLights)
			l.Activate (false);
			//lightsToTurnOff.Add(l);
	}

	private void FourthConfigOff()
	{
		fourthConfigActive = false;
		foreach (SwitchboardLight l in fourthConfigLights)
			l.Activate (false);
			//lightsToTurnOff.Add(l);
	}

	private void FifthConfigOff()
	{
		fifthConfigActive = false;
		foreach (SwitchboardLight l in fifthConfigLights)
			l.Activate (false);
			//lightsToTurnOff.Add(l);
	}

	private void SixthConfigOff()
	{
		sixthConfigActive = false;
		foreach (SwitchboardLight l in sixthConfigLights)
			l.Activate (false);
			//lightsToTurnOff.Add(l);
	}

	private void SeventhConfigOff()
	{
		seventhConfigActive = false;
		foreach (SwitchboardLight l in seventhConfigLights)
			l.Activate (false);
			//lightsToTurnOff.Add(l);
	}

	private void EighthConfigOff()
	{
		eighthConfigActive = false;
		foreach (SwitchboardLight l in eighthConfigLights)
			l.Activate (false);
			//lightsToTurnOff.Add(l);
	}

	private void NinthConfigOff()
	{
		ninthConfigActive = false;
		foreach (SwitchboardLight l in ninthConfigLights)
			l.Activate (false);
			//lightsToTurnOff.Add(l);
	}
}