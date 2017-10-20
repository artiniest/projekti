using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadGame : MonoBehaviour 
{
	public int LevelToLoad;
	float timeElapsed;

	void Update ()
	{
		timeElapsed++;

		if (timeElapsed > 1000) 
		{
			Application.LoadLevel (LevelToLoad);
		}
	}

}
