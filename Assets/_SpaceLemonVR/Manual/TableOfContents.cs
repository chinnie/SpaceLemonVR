using UnityEngine;

public class TableOfContents : MonoBehaviour
{
	public Transform canvas;
	public TMPro.TextMeshProUGUI text;

	private void Awake()
	{
		string table = "";
		for(int i = 2; i < canvas.childCount; i++)
		{
			table += i-1 + ". " + canvas.GetChild(i).name + "\n";
		}
		text.text = table;
	}
}