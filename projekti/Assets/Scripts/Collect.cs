using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour 
{
	void OnTriggerEnter (Collider other)
	{
		Escalate.score += 1;
		Destroy (this.gameObject);
	}
}
