using UnityEngine;
using System.Collections;

public class testOfAvabliebeCars : MonoBehaviour {
	public bool HaveCar1 = false;
	public bool HaveCar2 = false;
	public bool HaveCar3 = false;
	public bool HaveCar4 = false;
	public bool HaveCar5 = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (HaveCar1) {
			PlayerPrefs.SetInt ("Car1", 1);
		} else {
			PlayerPrefs.SetInt("Car1", 0);
		}

		if (HaveCar2) {
			PlayerPrefs.SetInt ("Car2", 1);
		} else {
			PlayerPrefs.SetInt("Car2", 0);
		}

		if (HaveCar3) {
			PlayerPrefs.SetInt ("Car3", 1);
		} else {
			PlayerPrefs.SetInt("Car3", 0);
		}

		if (HaveCar4) {
			PlayerPrefs.SetInt ("Car4", 1);
		} else {
			PlayerPrefs.SetInt("Car4", 0);
		}

		if (HaveCar5) {
			PlayerPrefs.SetInt ("Car5", 1);
		} else {
			PlayerPrefs.SetInt("Car5", 0);
		}



	
	}
}
