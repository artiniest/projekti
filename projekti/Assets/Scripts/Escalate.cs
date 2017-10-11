using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escalate : MonoBehaviour 
{
	static public float movementSpeed = 1.5f;
	public static float score = 0;

	void Start () 
	{
		InvokeRepeating("IncreaseSpeed", 5, 5);
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
