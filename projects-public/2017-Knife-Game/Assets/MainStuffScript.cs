﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainStuffScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey ("r")) {
			Application.LoadLevel (Application.loadedLevel);
		}
		
	}
}
