using UnityEngine;
using System.Collections;

public class NegativeGravity : MonoBehaviour {
	public float UpForce;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody> ().AddForce (new Vector3 (0, UpForce, 0));
	}
}
