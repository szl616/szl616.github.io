using UnityEngine;
using System.Collections;

public class hideGUI : MonoBehaviour {
	public Transform Tower;
	private Renderer rend;
	private Collider coll;

	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer>();
		rend.enabled = true;
		coll = GetComponent<Collider> ();
		coll.enabled = true;
	}
	
	// Update is called once per frame
	void Update () {

	}
}
