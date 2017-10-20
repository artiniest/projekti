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
		movementSpeed = 0;
		Invoke ("StartLate", 2);
		score = 0;
	}

	void Update ()
	{
		teksti.text = "Score " + score.ToString("F0");
	}

	void StartLate ()
	{
		movementSpeed = 3f;
	}
}
