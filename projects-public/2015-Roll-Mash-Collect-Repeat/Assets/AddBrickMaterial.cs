using UnityEngine;
using System.Collections;

public class AddBrickMaterial : MonoBehaviour {
	public Material[] mats;
	// Use this for initialization
	void Start () {
		GetComponent<Renderer> ().sharedMaterial = mats [Random.Range (0, 9)];
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
