using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTracker : MonoBehaviour 
{
	public static float score;

	void Start () 
	{
		GameObject.DontDestroyOnLoad (this.gameObject);	
	}

	void Update () 
	{
		print (score);
		score = Escalate.score;
	}
}
