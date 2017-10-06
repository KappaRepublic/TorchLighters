﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
* Class Name
* wallTrap Script
* 
* ==========
* 
* Created: 05/10/17
* Base Class: (If applicable) Name of the base class.
* Author(s): Rory McLean
*
* Purpose: The purpose of this file.
* Functionality for the walltrap
* ensuring the bullets and pressureplate will not activate unless the walltrap has been refilled
*/

public class SCR_WallTrap : MonoBehaviour 
{
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		Debug.Log (SCR_PressurePlate.platePressed);
	}

	void OnTriggerStay2D(Collider2D coll)
	{
		if (coll.gameObject.tag == "Player")
		{
			if (SCR_PressurePlate.platePressed == true)
			{
				if (Input.GetKeyDown (KeyCode.Space))
				{
					SCR_PressurePlate.platePressed = false;
				}
			}
				
		}

	}
}