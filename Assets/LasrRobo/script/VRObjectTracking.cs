//This script allows for 3D input tracking using Unity's built in tracking system

using UnityEngine;
using UnityEngine.VR;

public class VRObjectTracking : MonoBehaviour 
{
    public VRNode node;	//The device type that this game object represents

	void Awake()
	{
		//If VR isn't enabled, don't try to track this object
		if (!VRSettings.enabled)
			Destroy(this);
	}


	void Update()
	{
		//Update the position and rotation of this game object
		transform.localPosition = UnityEngine.VR.InputTracking.GetLocalPosition (node);
		transform.localRotation = UnityEngine.VR.InputTracking.GetLocalRotation (node);
	}
}
