﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
* Class Name
* Torch Script
* 
* ==========
* 
* Created: 05/10/17
* Base Class: (If applicable) Name of the base class.
* Author(s): Rory McLean
*
* Purpose: The purpose of this file.
* Functionality for the torchs
* lighting them when the player is in proxsimity and presses the light button
* 
*/

public class SCR_Torch : MonoBehaviour 
{
	bool torchLit = false;
	public Sprite unlitSprite;
	public Sprite litSprite;




	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		Debug.Log (torchLit);
	}


	void OnTriggerStay2D(Collider2D coll)
	{
		if (coll.gameObject.tag == "Player")
		{
			if (Input.GetKeyDown (KeyCode.Space))
			{
				
				torchLit = true;
				GetComponent<SpriteRenderer> ().sprite = litSprite;

			}
		}
	}
}