using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour 
{
	AudioSource audio;

	void OnTriggerEnter (Collider other) 
	{
		audio = GetComponent<AudioSource> ();
		audio.Play ();
	}
}
