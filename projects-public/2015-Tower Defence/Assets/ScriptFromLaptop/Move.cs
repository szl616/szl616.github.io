﻿using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
	public float speed = 10;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.forward * Time.deltaTime * speed);
	}
}