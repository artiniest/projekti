using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour 
{
	public GameObject[] platforms;
	int toInstantiate;
	int toInstantiate2;

	void Start () 
	{
		InvokeRepeating ("Spawn", 0, 1.5f);
	}

	void Spawn ()
	{
		toInstantiate = Random.Range (0, 6);
		toInstantiate2 = Random.Range (0, 6);


		Instantiate (platforms[toInstantiate], new Vector2 (Random.Range (5.7f, 0), 5.6f), Quaternion.identity);
		Instantiate (platforms [toInstantiate2], new Vector2 (Random.Range (0, -5.7f), 5.6f), Quaternion.identity);
	}
}
