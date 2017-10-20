using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassThrough : MonoBehaviour 
{
	public BoxCollider2D[] kollisio;
	public bool isOver;

	void Start () 
	{
		isOver = false;
		kollisio = GetComponents<BoxCollider2D> ();
		kollisio [1].enabled = false;
	}

	void Update ()
	{

		if (PlayerMovement.position < this.gameObject.transform.position.y) 
		{
			kollisio [0].enabled = false;
			kollisio [1].enabled = false;
			isOver = false;
		}

		if (PlayerMovement.position - 0.5f > this.gameObject.transform.position.y)
		{
			kollisio [0].enabled = true;
			kollisio [1].enabled = true;
			isOver = true;
		}
	}

}
