using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSkybox : MonoBehaviour 
{
	[SerializeField] private float rotation;

	void Update () 
	{
		float skyNow = RenderSettings.skybox.GetFloat ("_Rotation");
		RenderSettings.skybox.SetFloat ("_Rotation", skyNow + rotation);
	}
}