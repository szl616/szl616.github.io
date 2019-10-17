using UnityEngine;
using System.Collections;

public class buildningMode : MonoBehaviour {

	private Renderer rend;
	private Collider coll;

	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer>();
		rend.enabled = false;
		coll = GetComponent<Collider> ();
		coll.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (enableBuildningMode.BuildningMode) {
			rend.enabled = true;
			coll.enabled = true;

		} else {
			rend.enabled = false;
			coll.enabled = false;
		}
	
	}
}
