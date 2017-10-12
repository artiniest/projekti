using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlowGradient : MonoBehaviour 
{
	SpriteRenderer rendeeri;
	Color vari;
	GameObject Goo;

	public float distanssi;

	void Start ()
	{
		rendeeri = GetComponent<SpriteRenderer> ();
		Goo = GameObject.Find ("Goo");
	}

	void Update ()
	{
		rendeeri.color = vari;
		distanssi = Vector2.Distance (gameObject.transform.position, Goo.gameObject.transform.position);
		vari = GetComponent<SpriteRenderer> ().color;
		vari = new Color (1f,1f,1f, 1/distanssi*4);
	}
}
