using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour 
{
	public GameObject platform;
	public GameObject platformCoin;

	void Start () 
	{
		InvokeRepeating ("Spawn", 0, 1.5f);
	}

	void Spawn ()
	{
		Instantiate (platform, new Vector2 (Random.Range (5.7f, 0), 5.6f), Quaternion.identity);
		Instantiate (platform, new Vector2 (Random.Range (0, -5.7f), 5.6f), Quaternion.identity);
	}
}
