using UnityEngine;
using System.Collections;

public class left_move : MonoBehaviour {
	public Vector2 bird_speed = new Vector2 (4, 4);
	public Vector2 direction = new Vector2 (1, 0);
	// = GetComponent<Rigidbody2D> ().velocity;
	public GameObject bird_grey;
	
	// Update is called once per frame
	void Update () {
		Vector3 movement = new Vector3 (-bird_speed.x * direction.x, bird_speed.y * direction.y, 0);
		//movement *= Time.deltaTime;
		transform.Translate(movement);

	}

}