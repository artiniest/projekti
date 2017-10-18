using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickThings : MonoBehaviour 
{
	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.tag == "Player") 
		{
			Invoke ("DisableMovement", 0);
		}
	}

	IEnumerator DisableMovement ()
	{
		PlayerMovement.hasControl = false;
		yield return new WaitForSeconds (1);
		PlayerMovement.hasControl = true;
	}
}
