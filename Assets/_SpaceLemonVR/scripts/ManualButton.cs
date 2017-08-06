using NewtonVR;
using UnityEngine;

public class ManualButton : MonoBehaviour
{
	private NVRHand hand;
	private Material mat;
	private Color normalColor;

	public Color hoverColor;
	public Color clickColor;

	public bool isRightButton;
	public Manual manual;

	private void Awake()
	{
		mat = GetComponent<MeshRenderer>().material;
		normalColor = mat.color;
	}

	private void onClick()
	{
		manual.nextPage(isRightButton);
	}

	private void Update()
	{
		if (hand != null)
		{
			if (hand.UseButtonDown)
				onClick();
			mat.color = (hand.UseButtonPressed ? mat.color = clickColor : mat.color = hoverColor);
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		hand = other.attachedRigidbody.GetComponent<NVRHand>();
		mat.color = hoverColor;
	}

	private void OnTriggerExit(Collider other)
	{
		hand = null;
		mat.color = normalColor;
	}
}