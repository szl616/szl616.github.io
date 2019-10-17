using UnityEngine;
using System.Collections;

public class selected : MonoBehaviour {


	//Selecting
	public bool objectSelected = false;
	public bool mouseOnObject = false;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if(Input.GetButtonDown("Fire1") && !mouseOnObject)
		{
			objectSelected = false;
		}

	}

	void OnMouseDown()
	{
		objectSelected = true;
	}

	void OnMouseEnter()
	{
		mouseOnObject = true;
	}
	
	void OnMouseExit()
	{
		mouseOnObject = false;
	}
	
}
