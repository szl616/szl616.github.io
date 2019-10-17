using UnityEngine;
using System.Collections;

public class resetData : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log ("Money: "+PlayerPrefs.GetInt ("Money"));
		Debug.Log ("Car Choosen: "+PlayerPrefs.GetInt ("ChoosenCar"));
		Debug.Log ("Car1: "+PlayerPrefs.GetInt ("Car1"));
		Debug.Log ("Car2: "+PlayerPrefs.GetInt ("Car2"));
		Debug.Log ("Car3: "+PlayerPrefs.GetInt ("Car3"));
		Debug.Log ("Car4: "+PlayerPrefs.GetInt ("Car4"));
		Debug.Log ("Car5: "+PlayerPrefs.GetInt ("Car5"));

	
	}

	void OnMouseDown ()
	{
		moveByTouch.ChoosenObject = 1;
		PlayerPrefs.SetInt("Money", 0);
		PlayerPrefs.SetInt("ChoosenCar", 1);
		PlayerPrefs.SetInt("Car1", 1);
		PlayerPrefs.SetInt("Car2", 0);
		PlayerPrefs.SetInt("Car3", 0);
		PlayerPrefs.SetInt("Car4", 0);
		PlayerPrefs.SetInt("Car5", 0);
		PlayerPrefs.SetInt("Car1Armor", 0);
		PlayerPrefs.SetInt("Car2Armor", 0);
		PlayerPrefs.SetInt("Car3Armor", 0);
		PlayerPrefs.SetInt("Car4Armor", 0);
		PlayerPrefs.SetInt("Car5Armor", 0);

	}
}
