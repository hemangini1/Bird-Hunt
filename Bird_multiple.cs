using UnityEngine;
using System.Collections;

public class Bird_multiple : MonoBehaviour {
	public GameObject bird;
	public Vector3 spawnValues;
	public int birdCount;
	public float spawnWait;
	public float startWait;
	public float waveWait;
	public Vector3 originalposition;
	public Vector3 spawnPosition ;
	public Quaternion spawnRotation; 
	public grey_multiple g;
	public red_multiple r;
	public Bird_multiple b;


	GameObject obj;

	void Start ()
	{	
		StartCoroutine (SpawnWaves ());   
    	b.birdCount = 10;


	}


	public IEnumerator SpawnWaves ()
	{
		yield return new WaitForSeconds (0.5f);
		while (true)
		{  
			b.birdCount++;

			for (int i = 0; i < birdCount; i++)
			{
				spawnPosition= new Vector3 (spawnValues.x, Random.Range (spawnValues.y,-spawnValues.y), spawnValues.z);
				spawnRotation= Quaternion.identity;
				Instantiate (bird, spawnPosition, spawnRotation);
				originalposition=bird.transform.position;

				yield return new WaitForSeconds (spawnWait);
				if(b.birdCount>15){
					g.enabled=true;
				    //r.birdCount++;


					if(r.birdCount>10)
		     		{b.spawnWait=2;
						r.enabled=true;
						//r.birdCount--;
						r.spawnWait--;
						r.birdCount++;
						g.birdCount++;
					}
					}
			
			}			yield return new WaitForSeconds (waveWait);
		}

		//StartCoroutine (changeCollision ());
	}


}
