using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WireEnd : MonoBehaviour 
{
	private Rigidbody thisRB;
	private SwitchboardLights switchBoard;

	public int ID;

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
			AttachToSocket (hit.GetComponent<WireSocket>());
	}

	void OnTriggerExit(Collider hit)
	{
		if (hit.GetComponent<WireSocket> () && null != currentSocket) 
			DetachFromSocket ();
	}

	private void AttachToSocket(WireSocket socket)
	{
		//don't plug into full slot
		if (null != socket.currentWire)
			return;

		thisRB.isKinematic = true;
		currentSocket = socket;
		currentSocket.currentWire = this;
		transform.position = socket.transform.position;
		switchBoard.UpdateSwitchboardLights ();
	}

	public void DetachFromSocket()
	{
		if (null != currentSocket) 
		{
			currentSocket.currentWire = null;
			switchBoard.UpdateSwitchboardLights ();
			currentSocket = null;
		}
	}
}