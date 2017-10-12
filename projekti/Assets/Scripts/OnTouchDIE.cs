using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTouchDIE : MonoBehaviour 
{
	void OnTriggerEnter2D (Collider2D other) 
	{
		Application.LoadLevel (1);
	}
}
