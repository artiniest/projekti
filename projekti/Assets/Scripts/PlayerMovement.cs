using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour 
{
	public int levelToLoad = 2;
	bool hasControl = true;
	bool hasDied = false;

	public float moveSpeed = 10f;
	public int jumpHeight = 50;
	public static float position;
	public GameObject concussion;
	private Rigidbody2D rigb;

	SpriteRenderer renderero;
	Animator animaattori;
	bool isGrounded;

	void Awake()
	{
		concussion.SetActive (false);
		rigb = GetComponent<Rigidbody2D> ();
		renderero = GetComponent<SpriteRenderer> ();
		animaattori = GetComponent<Animator> ();
	}

	void Update () 
	{
		position = transform.position.y;
		if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
		{
			animaattori.SetBool ("IsMoving", true);
			renderero.flipX = false;
		}

		if (Input.GetKeyDown (KeyCode.A) || Input.GetKeyDown (KeyCode.LeftArrow)) 
		{
			animaattori.SetBool ("IsMoving", true);
			renderero.flipX = true;
		} 

		if (Input.GetKeyUp (KeyCode.A) || Input.GetKeyUp (KeyCode.RightArrow) || Input.GetKeyDown (KeyCode.D) || Input.GetKeyDown (KeyCode.RightArrow)) 
		{
			animaattori.SetBool ("IsMoving", false);
		}

		if (hasDied == true) 
		{
			animaattori.SetBool ("hasDied", true);
		}


		if (Input.GetKeyDown (KeyCode.Space) && isGrounded == true && hasControl == true) 
		{
			rigb.AddForce (new Vector3 (0, jumpHeight, 0), ForceMode2D.Impulse);
			isGrounded = false;
		}
	}

	void FixedUpdate () 
	{
		
		if (hasControl == true) 
		{
			float movement = Input.GetAxis ("Horizontal") * Time.deltaTime * moveSpeed;
			rigb.velocity = new Vector2 (movement, rigb.velocity.y);
		}

		if (hasControl == false) 
		{
			rigb.velocity = new Vector2 (0, rigb.velocity.y);
		}
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.tag == "Goo") 
		{
			hasControl = false;
			hasDied = true;
			Invoke ("GoDie", 2.5f);
		}

		if (other.tag == "Platform") 
		{
			transform.SetParent (other.gameObject.transform);
			animaattori.SetBool ("IsGrounded", true);
		}
			
		if (other.tag == "Brick") 
		{
			Invoke ("DisableMovement", 0);
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
		if (other.tag == "Platform" && hasControl == true) 
		{
			transform.SetParent (null);
			animaattori.SetBool ("IsGrounded", false);
		}
	}

	void DisableMovement () 
	{
		concussion.SetActive (true);
		hasControl = false;
		Invoke ("EnableMovement", 1f);
	}

	void EnableMovement ()
	{
		hasControl = true;
		concussion.SetActive (false);
	}
		
	void GoDie ()
	{
		Application.LoadLevel (2);
	}
}
