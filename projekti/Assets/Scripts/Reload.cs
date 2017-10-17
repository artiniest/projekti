using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reload : MonoBehaviour 
{
	
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.U)) 
		{
			Application.LoadLevel (2);
		}
	}
}
