using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class score : MonoBehaviour {
	collide_bird c;
	public Text Score;
	// Use this for initialization
	void Start () {
		Score.text = "Score:" + c.num;
	}
	
	// Update is called once per frame
	void Update () {

	}
}
