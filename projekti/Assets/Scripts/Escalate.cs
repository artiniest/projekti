using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escalate : MonoBehaviour 
{
	static public float movementSpeed = 1.5f;
	float score = 0;

	void Start () 
	{
		InvokeRepeating("Increase", 5, 5);
	}

	void IncreaseSpeed ()
	{
		movementSpeed += 0.5f;
	}

	void Update ()
	{
		score += Time.deltaTime;

		//print (score.ToString("F0"));
	}
}
