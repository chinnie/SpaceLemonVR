using UnityEngine;

public class SpaceshipRumble : MonoBehaviour
{
	public NewtonVR.NVRLever lever;
	public float rumbleLength;
	public float posMagnitude;
	public float rotMagnitude;
	public float skyRotationNew;

	private float rumbleStarted;
	private bool isRumbling = false;
	private bool hasRumbled = false;
	private RotateSkybox skyMover;
	private float skyRotationOld;

	void Start()
	{
		skyMover = FindObjectOfType<RotateSkybox> ();
		skyRotationOld = skyMover.rotation;
	}

	public void startRumble()
	{
		if (hasRumbled)
			return;

		hasRumbled = true;
		isRumbling = true;
		rumbleStarted = Time.time;
		skyMover.rotation = skyRotationNew;
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
			skyMover.rotation = skyRotationOld;
			return;
		}

		transform.localPosition = Random.insideUnitSphere * posMagnitude;
		transform.localEulerAngles = Random.insideUnitSphere * rotMagnitude;
	}
}