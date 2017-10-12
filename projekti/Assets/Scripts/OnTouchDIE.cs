using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTouchDIE : MonoBehaviour 
{
	public static bool diediedie = false;

	void OnTriggerEnter2D (Collider2D other) 
	{
			diediedie = true;
			Invoke ("GoDie", 2.5f);
	}

	void GoDie ()
	{
		Application.LoadLevel (1);
	}
}
