using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveThings : MonoBehaviour 
{
	void Update () 
	{
		this.transform.Translate (new Vector2 (0, CameraPan.panSpeed*-Time.deltaTime));
	}
}
