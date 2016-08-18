using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class gui : MonoBehaviour {
	public Button startText;
	void Start()
	{
		startText = startText.GetComponent<Button>();
	}

	public void NoPress()
	{
		startText.enabled = true;
	}
public void StartLevel()
	{
		Application.LoadLevel (1);
	}
	public void PLAY_GUIDE()
	{
		Application.LoadLevel (3);
	}
	public void quit()
	{
		Application.Quit ();
	}

}
