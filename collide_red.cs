using UnityEngine;
using System.Collections;

public class collide_red : MonoBehaviour {
	public GameObject bird_red;
	public Vector2 mousePosition;
	public float moveSpeed_red;
	// Use this for initialization

	void OnMouseOver(){
		
		if (Input.GetMouseButtonDown(0)||(Input.touchCount == 1) &&
		    (Input.GetTouch(0).phase == TouchPhase.Began)) 
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
			Rigidbody2D obj = hit.collider.gameObject.AddComponent<Rigidbody2D>();
			if(hit.collider != null &&hit.transform!=null)
			{	 print ("in");
				Debug.Log ("Target Position: " + hit.collider.gameObject.transform.position);
				// Add the rigidbody.
				obj.GetComponent<Rigidbody2D>().gravityScale=10;
				
			}
			
		}
		
	}
}
