using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GotoLevel : MonoBehaviour {

	public int Level;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Goto(){
		Level = int.Parse(transform.GetChild (0).GetComponent<Text> ().text);
		GameObject.Find ("Main Camera").GetComponent<MoveCamera> ().GotoLevel (Level);
	}
}
