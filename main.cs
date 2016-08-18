using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class main : MonoBehaviour {
	public int time;
	public GameObject bird;
	public Text time_text;

	// Use this for initialization
	void Start () {
		time = 4000;
	}

	// Update is called once per frame
	void Update () {

		time--;
		time_text.text = ""+ time;
		if (time < 0) {
			Application.LoadLevel (2);


		}

	}
}
