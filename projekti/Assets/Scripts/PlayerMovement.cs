using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour 
{
	public float moveSpeed = 10f;
	public int jumpHeight = 50;

	SpriteRenderer renderer;
	Animation animaattori;
	bool isGrounded;

	void Awake()
	{
		renderer = GetComponent<SpriteRenderer> ();
		animaattori = GetComponent<Animation> ();
	}

	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
			{
				renderer.flipX = false;
			}

			if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
			{
				renderer.flipX = true;
			}
	}

	void FixedUpdate () 
	{
		float movement = Input.GetAxis ("Horizontal") * Time.deltaTime * moveSpeed;

		Rigidbody2D rigb = GetComponent<Rigidbody2D> ();
		rigb.transform.Translate (new Vector2 (movement, 0));
		/*Vector2 newPos = new Vector2 (transform.position.x + movement, transform.position.y);
		rigb.MovePosition (newPos);*/

		if (Input.GetKey (KeyCode.Space) && isGrounded == true) 
		{
			rigb.AddForce (new Vector3 (0, jumpHeight, 0), ForceMode2D.Impulse);
		}
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.tag == "Platform") 
		{
			transform.SetParent (other.gameObject.transform);
			isGrounded = true;
		}
	}

	void OnTriggerExit2D (Collider2D other)
	{
		if (other.tag == "Platform") 
		{
			transform.SetParent (null);
			isGrounded = false;
		}
	}
}
