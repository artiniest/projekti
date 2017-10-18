using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickSpawn : MonoBehaviour 
{
	public GameObject[] spawns;
	public GameObject brick;

	void Start () 
	{
		InvokeRepeating ("Spawn", 5, 5); 
	}

	void Spawn ()
	{
		Instantiate (brick, spawns [Random.Range (0, spawns.Length)].transform.position, Quaternion.identity);
	}
}
