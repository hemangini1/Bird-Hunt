using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CLICK : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0) || (Input.touchCount == 1) &&
			(Input.GetTouch (0).phase == TouchPhase.Began)) {
			Application.LoadLevel(0);
		}
	}
}
