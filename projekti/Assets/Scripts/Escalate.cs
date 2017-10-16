using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Escalate : MonoBehaviour 
{
	static public float movementSpeed = 3f;
	public static float score = 0;
	public Text teksti;

	void Start () 
	{
		score = 0;
		//InvokeRepeating("IncreaseSpeed", 5, 5);
	}

	void IncreaseSpeed ()
	{
		movementSpeed += 0.5f;
	}

	void Update ()
	{
		teksti.text = "Score " + score.ToString("F0");
		//score += Time.deltaTime;

		//print (score.ToString("F0"));
	}
}
