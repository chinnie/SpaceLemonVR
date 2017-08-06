using UnityEngine;

public class Manual : MonoBehaviour
{
	public Transform canvas;

	private int i;

	private void Awake()
	{
		i = 0;
		showPage(0);
	}

	public void nextPage(bool next)
	{
		i += (next ? 1 : -1);
		i = Mathf.Max(0, Mathf.Min(canvas.childCount, i));

		showPage(i);
	}

	private void showPage(int page)
	{
		for (int j = 0; j < transform.childCount; j++)
			canvas.GetChild(j).gameObject.SetActive(j == page);
	}
}