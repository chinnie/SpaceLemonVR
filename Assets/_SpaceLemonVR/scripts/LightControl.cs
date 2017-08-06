using UnityEngine;

public class LightControl : MonoBehaviour
{
	public Light theLight;
	public NewtonVR.NVRSlider slider;

	private void Update()
	{
		theLight.intensity = slider.CurrentValue;
	}
}