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
		Invoke ("Starting", 2);
		score = 0;
		movementSpeed = 0;
	}

	void Update ()
	{
		teksti.text = "Score " + score.ToString("F0");
	}

	void Starting ()
	{
		movementSpeed = 3f;
	}
}
