using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour 
{
	public int levelToLoad = 1;
	bool hasDied = false;

	public float moveSpeed = 10f;
	public int jumpHeight = 50;
	public static float position;
	private Rigidbody2D rigb;


	SpriteRenderer renderer;
	Animator animaattori;
	bool isGrounded;

	void Awake()
	{
		rigb = GetComponent<Rigidbody2D> ();
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

		if (hasDied == true) 
		{
			animaattori.SetBool ("hasDied", true);
		}
	}

	void FixedUpdate () 
	{
		
		if (hasDied == false) 
		{
			float movement = Input.GetAxis ("Horizontal") * Time.deltaTime * moveSpeed;
			rigb.velocity = new Vector2 (movement, rigb.velocity.y);

			if (Input.GetKeyDown (KeyCode.Space) && isGrounded == true) 
			{
				rigb.AddForce (new Vector3 (0, jumpHeight, 0), ForceMode2D.Impulse);
				isGrounded = false;
			}
		}
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.tag == "Goo") 
		{
			hasDied = true;
			Invoke ("GoDie", 2.5f);
		}

		if (other.tag == "Platform") 
		{
			transform.SetParent (other.gameObject.transform);
			animaattori.SetBool ("IsGrounded", true);
		}
	}

	void OnTriggerStay2D (Collider2D other)
	{
		if (other.tag == "Platform") 
		{
			isGrounded = true;
		}
	}

	void OnTriggerExit2D (Collider2D other)
	{
		if (other.tag == "Platform" && hasDied == false) 
		{
			transform.SetParent (null);
			animaattori.SetBool ("IsGrounded", false);
		}
	}
		
	void GoDie ()
	{
		Application.LoadLevel (levelToLoad);
	}
}
