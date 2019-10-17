using UnityEngine;
using System.Collections;

public class towerGUIBack : MonoBehaviour {

	private turret script1; 
	public GameObject tower1;

	// Use this for initialization
	void Start () {
		script1 = tower1.GetComponent<turret>();
	}
	
	// Update is called once per frame
	void Update () {

	
	}

	void OnMouseDown ()
	{
		script1.selected = false;
	}
}
