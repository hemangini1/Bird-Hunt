using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class collide_bird : MonoBehaviour {

	Bird_multiple b;
	public GameObject bird;
	public Vector2 mousePosition;
	public float moveSpeed;
	public int birdCount;
	public int ScoreValue;
	public Text scoreText;
	public int num;

	void Update () {
		OnMouseOver ();

}
	void OnMouseOver(){

		if (Input.GetMouseButtonDown(0)||(Input.touchCount == 1) &&
		                                      (Input.GetTouch(0).phase == TouchPhase.Began)) 
		{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
		
		if(hit.collider != null &&hit.transform!=null)
			{   Rigidbody2D obj = hit.collider.gameObject.AddComponent<Rigidbody2D>();  
				 num++;
				 scoreText.text = "Score: " + num;
				GetComponent<AudioSource>().Play();
				Destroy (obj);


			}

		
										
	}
	
}
}