using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPan : MonoBehaviour 
{
	public static float panSpeed = 10f;
	public GameObject background;
	GameObject backgroundClone;

	void Awake () 
	{
		background = Resources.Load("tempWall") as GameObject;
		Instantiate (background, new Vector2(0,0), Quaternion.identity);
	}
	void Update () 
	{
		
	}
}
