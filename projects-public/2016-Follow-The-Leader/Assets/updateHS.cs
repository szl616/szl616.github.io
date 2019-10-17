using UnityEngine;
using System.Collections;

public class updateHS : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<TextMesh> ().text = ""+PlayerPrefs.GetInt ("HS");
	}
}
