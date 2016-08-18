using UnityEngine;
using System.Collections;

public class grey_multiple : MonoBehaviour {

	public GameObject bird_grey;
	public Vector3 spawnValues;
	public int birdCount;
	public float spawnWait;
	public float startWait;
	public float waveWait;
	 Vector3 originalposition;

	 Vector3 spawnPosition ;
	 Quaternion spawnRotation; 
	public grey_multiple g;
	public red_multiple r;
	public Bird_multiple b;
	GameObject obj;
	
	void Start ()
	{	
		StartCoroutine (SpawnWaves ());   
		g.birdCount = 0;
		
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
				Instantiate (bird_grey, spawnPosition, spawnRotation);
				originalposition=bird_grey.transform.position;
				
				yield return new WaitForSeconds (spawnWait);
     				
			}			yield return new WaitForSeconds (waveWait);
			birdCount++;
		}

	}
	
	
}
