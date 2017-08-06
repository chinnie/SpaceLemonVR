using NewtonVR;
using UnityEngine;

public class TopCabinet : NewtonVR.NVRInteractableItem
{
	public GameObject wires;
	private bool firstTime = true;

	public override void BeginInteraction(NVRHand hand)
	{
		base.BeginInteraction(hand);
		if (firstTime)
		{
			ForceDetach(hand);
			wires.SetActive(true);
		}
		firstTime = false;
	}
}