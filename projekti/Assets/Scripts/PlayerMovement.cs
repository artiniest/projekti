using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour 
{
	public float moveSpeed = 10f;
	public int jumpHeight = 50;

	bool isGrounded;

	void FixedUpdate () 
	{
		float movement = Input.GetAxis ("Horizontal")*Time.deltaTime*moveSpeed;
		transform.Translate (movement, 0, 0);

		Rigidbody rb = GetComponent<Rigidbody> ();
		if (Input.GetKey (KeyCode.Space) && isGrounded == true) 
		{
			rb.AddForce (new Vector3 (0, jumpHeight, 0), ForceMode.Impulse);
		}
	}

	void OnTriggerEnter (Collider other)
	{
		if (other.tag == "Platform") 
		{
			isGrounded = true;
		}
	}

	void OnTriggerExit (Collider other)
	{
		if (other.tag == "Platform") 
		{
			isGrounded = false;
		}
	}
}
