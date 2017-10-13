using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassThrough : MonoBehaviour 
{
	Vector2 playerPos;
	public BoxCollider2D[] kollisio;
	public bool isOver;

	void Start () 
	{
		isOver = false;
		playerPos = GameObject.FindGameObjectWithTag ("Player").transform.position;
		kollisio = GetComponents<BoxCollider2D> ();
	}

	void Update ()
	{
		if (PlayerMovement.position < this.gameObject.transform.position.y) 
		{
			kollisio [0].enabled = false;
			kollisio [1].enabled = false;
			isOver = false;
		}

		if (PlayerMovement.position > this.gameObject.transform.position.y)
		{
			kollisio [0].enabled = true;
			kollisio [1].enabled = true;
			isOver = true;
		}
	}

}
