using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBG : MonoBehaviour 
{
	float moveSpeed = 1.5f;
	Vector2 returnPos = new Vector2 (0, 25);

	void Update () 
	{
		transform.Translate(new Vector2 (0, moveSpeed * -Time.deltaTime));
		if (this.tag == "Background" && this.transform.position.y < -15) 
		{
			transform.position = returnPos;
		}

		if (this.tag == "Platform" && this.transform.position.y < -15) 
		{
			Destroy (this.gameObject);
		}
	}
}
