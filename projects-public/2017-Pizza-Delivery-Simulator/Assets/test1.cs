﻿using UnityEngine;
using System.Collections;

public class test1 : MonoBehaviour {
    public int speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        transform.Translate(Vector3.forward * speed * Time.deltaTime);
	
	}
}
