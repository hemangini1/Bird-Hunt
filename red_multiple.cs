using UnityEngine;
using System.Collections;

public class red_multiple : MonoBehaviour {

	public GameObject bird_red;
	public Vector3 spawnValues;
	public int birdCount;
	public float spawnWait;
	public float startWait;
	public float waveWait;
	 Vector3 originalposition;

	public Vector3 spawnPosition ;
	public Quaternion spawnRotation; 
	public grey_multiple g;
	public red_multiple r;
	public Bird_multiple b;
	

	GameObject obj;
	
	void Start ()
	{	
		StartCoroutine (SpawnWaves ());   
		r.birdCount = 5;
	}

	
	public IEnumerator SpawnWaves ()
	{
		yield return new WaitForSeconds (0.5f);
		while (true)
		{
			for (int i = 0; i < birdCount; i++)
			{
				spawnPosition= new Vector3 (spawnValues.x, Random.Range (spawnValues.y,-spawnValues.y), spawnValues.z);
				spawnRotation= Quaternion.identity;
				Instantiate (bird_red, spawnPosition, spawnRotation);
				originalposition=bird_red.transform.position;
				
				yield return new WaitForSeconds (spawnWait);

			}			yield return new WaitForSeconds (waveWait);
		}

		//StartCoroutine (changeCollision ());
	}
	
	
}
