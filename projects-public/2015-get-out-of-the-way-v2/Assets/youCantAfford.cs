using UnityEngine;
using System.Collections;

public class youCantAfford : MonoBehaviour {
	public static bool show;
	private Renderer rend;
	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer> ();
		
		
	}
	
	// Update is called once per frame
	void Update () {
		if (show) {
			rend.enabled = true;
		} else {
			rend.enabled = false;
		}
		
	}
}
