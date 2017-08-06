using UnityEngine;

public class SpaceshipRumble : MonoBehaviour
{
	public NewtonVR.NVRLever lever;
	public float rumbleLength;
	public float posMagnitude;
	public float rotMagnitude;

	private float rumbleStarted;
	private bool isRumbling = false;
	private bool hasRumbled = false;

	public void startRumble()
	{
		if (hasRumbled)
			return;

		hasRumbled = true;
		isRumbling = true;
		rumbleStarted = Time.time;
	}

	private void Update()
	{
		if (!hasRumbled && lever.LeverEngaged)
			startRumble();

		if (!isRumbling)
			return;

		if(Time.time - rumbleStarted > rumbleLength)
		{
			isRumbling = false;
			transform.localPosition = Vector3.zero;
			transform.localEulerAngles = Vector3.zero;
			return;
		}

		transform.localPosition = Random.insideUnitSphere * posMagnitude;
		transform.localEulerAngles = Random.insideUnitSphere * rotMagnitude;
	}
}