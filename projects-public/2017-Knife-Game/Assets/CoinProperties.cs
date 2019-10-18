using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinProperties : MonoBehaviour {

    public float rotateSpeed = 100f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.Rotate(Vector3.right * rotateSpeed);
	}
}
