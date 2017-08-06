using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WireEnd : MonoBehaviour 
{
	private Rigidbody thisRB;
	private SwitchboardLights switchBoard;

	[SerializeField] private int ID;
	[SerializeField] private WireSocket startingSocket;

	[HideInInspector] public WireSocket currentSocket;

	void Start()
	{
		thisRB = GetComponent<Rigidbody> ();
		switchBoard = FindObjectOfType<SwitchboardLights> ();
		AttachToSocket (startingSocket);
	}

	void OnTriggerStay(Collider hit)
	{
		if (hit.GetComponent<WireSocket> () && null == currentSocket && thisRB.useGravity) 
		{
			AttachToSocket (hit.GetComponent<WireSocket>());
			Debug.Log ("attach 2");
		}
	}

	void OnTriggerExit(Collider hit)
	{
		if (hit.GetComponent<WireSocket> () && null != currentSocket) 
		{
			DetachFromSocket ();
			Debug.Log ("detach 2");
		}
	}

	private void AttachToSocket(WireSocket socket)
	{
		thisRB.isKinematic = true;
		currentSocket = socket;
		transform.position = socket.transform.position;

		//if(0 == ID)
			//transform.rotation = Quaternion.Euler (socket.attachedRotation0);

		//else
			//transform.rotation = Quaternion.Euler (socket.attachedRotation1);

		switchBoard.CheckConfig (ID, socket.ID, true);
	}

	public void DetachFromSocket()
	{
		if (null != currentSocket) 
		{
			switchBoard.CheckConfig (ID, currentSocket.ID, false);
			currentSocket = null;
		}
	}
}