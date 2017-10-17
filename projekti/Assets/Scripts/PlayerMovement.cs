using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour 
{
	public float moveSpeed = 10f;
	public int jumpHeight = 50;
	public static float position;


	SpriteRenderer renderer;
	Animator animaattori;
	bool isGrounded;

	void Awake()
	{
		OnTouchDIE.diediedie = false;
		renderer = GetComponent<SpriteRenderer> ();
		animaattori = GetComponent<Animator> ();
	}

	void Update () 
	{
		position = transform.position.y;
		if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
		{
			animaattori.SetBool ("IsMoving", true);
			renderer.flipX = false;
		}

		if (Input.GetKeyDown (KeyCode.A) || Input.GetKeyDown (KeyCode.LeftArrow)) 
		{
			animaattori.SetBool ("IsMoving", true);
			renderer.flipX = true;
		} 

		if (Input.GetKeyUp (KeyCode.A) || Input.GetKeyUp (KeyCode.RightArrow) || Input.GetKeyDown (KeyCode.D) || Input.GetKeyDown (KeyCode.RightArrow)) 
		{
			animaattori.SetBool ("IsMoving", false);
		}

		if (OnTouchDIE.diediedie == true) 
		{
			animaattori.SetBool ("hasDied", true);
		}
	}

	void FixedUpdate () 
	{
		if (OnTouchDIE.diediedie == false) 
		{
			float movement = Input.GetAxis ("Horizontal") * Time.deltaTime * moveSpeed;

			Rigidbody2D rigb = GetComponent<Rigidbody2D> ();
			rigb.transform.Translate (new Vector2 (movement, 0));


			if (Input.GetKey (KeyCode.Space) && isGrounded == true) 
			{
				rigb.AddForce (new Vector3 (0, jumpHeight, 0), ForceMode2D.Impulse);
			}
		}
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.tag == "Platform") 
		{
			transform.SetParent (other.gameObject.transform);
			isGrounded = true;
			animaattori.SetBool ("IsGrounded", true);
		}
	}

	void OnTriggerExit2D (Collider2D other)
	{
		if (other.tag == "Platform" && OnTouchDIE.diediedie == false) 
		{
			transform.SetParent (null);
			isGrounded = false;
			animaattori.SetBool ("IsGrounded", false);
		}
	}
}
