using UnityEngine;
using System.Collections;

public class enableBuildningMode : MonoBehaviour {

	public static bool BuildningMode = false;
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
		if (BuildningMode) {
			coll.enabled = false;
			rend.enabled = false;
		}
	
	}

	void OnMouseDown ()
	{
		BuildningMode = true;
	}

	void EndBuildningMode()
	{
		BuildningMode = false;
		coll.enabled = true;
		rend.enabled = true;
	}

}
