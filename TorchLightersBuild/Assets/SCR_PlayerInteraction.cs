﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_PlayerInteraction : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnTriggerStay2D(Collider2D col)
	{
		// Show that object has been found to debug information
		Debug.Log ("Found something");

		// Check for player input as long as a valid target is available
		if (Input.GetMouseButtonDown (0)) {
			Debug.Log ("Starting Interaction");
			if (col.gameObject.tag == "Chest") {
				col.gameObject.GetComponent<SCR_Chest> ().refillChest ();
			}
			if (col.gameObject.tag == "Lever") {
				Debug.Log ("Spike Lever");
				col.gameObject.GetComponent<SCR_SpikeLever> ().activate ();
			}
		}
	}
}
