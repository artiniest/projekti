﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBG : MonoBehaviour 
{
	public float moveSpeed;
	Vector2 returnPos = new Vector2 (0, 25);

	void Update ()
	{
		moveSpeed = Escalate.movementSpeed;
	}

	void FixedUpdate () 
	{
		transform.Translate(new Vector2 (0, moveSpeed * -Time.deltaTime));
		if (this.tag == "Background" && this.transform.position.y < -15) 
		{
			transform.position = returnPos;
		}

		if (this.tag != "Background" && this.transform.position.y < -15) 
		{
			Destroy (this.gameObject);
		}
	}
}
