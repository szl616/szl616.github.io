using UnityEngine;
using System.Collections;

public class PlayerInformation : MonoBehaviour {
	public bool ResetData = false;
	public int SelectedCar = 1;



	// Use this for initialization
	void Start () {
		if (ResetData) {
			PlayerPrefs.SetInt("Money", 0);
			PlayerPrefs.SetInt("CarChoosen", 0);
			PlayerPrefs.SetInt("Car1", 0);
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
	
	// Update is called once per frame
	void Update () {
	
	}
}
