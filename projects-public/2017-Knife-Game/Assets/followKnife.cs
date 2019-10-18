using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followKnife : MonoBehaviour {
    public Transform knife;
    private Vector3 Offset;
    private Vector3 camPosition;
	// Use this for initialization
	void Start () {
        camPosition = transform.position;
        Offset = camPosition - knife.position;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = knife.position + Offset;
	}
}
