using UnityEngine;

public class TableOfContents : MonoBehaviour
{
	public Transform canvas;
	public TMPro.TextMeshProUGUI text;

	private void Awake()
	{
		string table = "";
		for(int i = 0; i < canvas.childCount; i++)
		{
			table += i + ". " + canvas.GetChild(i).name + "\n";
		}
		text.text = table;
	}
}