using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour 
{
	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.tag == "Player") 
		{
			Escalate.score += 1;
			Destroy (this.gameObject);
		}
	}
}
