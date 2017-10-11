using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour 
{
	public GameObject platform;

	void Start () 
	{
		InvokeRepeating ("Spawn", 0, 1);
	}

	void Spawn ()
	{
		Instantiate (platform, new Vector2 (Random.Range (5.7f, -5.7f), 5.6f), Quaternion.identity);
	}
}
