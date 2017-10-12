using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour 
{
	public Text gameOverTeksti;

	void Start ()
	{
		gameOverTeksti.text = "Score: " + ScoreTracker.score.ToString("F0");
	}

	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Space)) 
		{
			Application.LoadLevel (0);
		}
	}
}
