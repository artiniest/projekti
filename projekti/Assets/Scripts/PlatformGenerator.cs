using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour 
{
	public GameObject[] patternPlatforms;

	void Start () 
	{
		InvokeRepeating ("SpawnBig", 2f, 6.5f);
	}
	void SpawnBig ()
	{
		Instantiate (patternPlatforms [Random.Range (0,patternPlatforms.Length)], new Vector2 (0,13), Quaternion.identity);
	}
}
