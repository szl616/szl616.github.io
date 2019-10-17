using UnityEngine;
using System.Collections;

public class chooseCarInGarage : MonoBehaviour {
	private Renderer rend;
	private Collider2D coll;
	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer> ();
		coll = GetComponent<Collider2D>();


	}
	
	// Update is called once per frame
	void Update () {

		switch (moveByTouch.ChoosenObject) {
		case 1: if(PlayerPrefs.GetInt ("Car1")==1)
				{
				notavailableScript.show = false;
				if(PlayerPrefs.GetInt ("ChoosenCar") != 1)
				{
					rend.enabled = true;
					coll.enabled = true;

				}else{
					coll.enabled = false;
					rend.enabled = false;
				}}else{	
				notavailableScript.show =true;
				coll.enabled = false;
				rend.enabled = false;
				}
			break;
		case 2: if(PlayerPrefs.GetInt ("Car2")==1)
				{
				notavailableScript.show = false;
				if(PlayerPrefs.GetInt ("ChoosenCar") != 2)
				{
					rend.enabled = true;
					coll.enabled = true;
				}else{
					coll.enabled = false;
					rend.enabled = false;
				}}else{	
				notavailableScript.show =true;
				coll.enabled = false;
				rend.enabled = false;
				}
			break;
		case 3: if(PlayerPrefs.GetInt ("Car3")==1)
				{
				notavailableScript.show = false;
				if(PlayerPrefs.GetInt ("ChoosenCar") != 3)
				{
					rend.enabled = true;
					coll.enabled = true;

				}else{
					coll.enabled = false;
					rend.enabled = false;
				}}else{	
				notavailableScript.show =true;
				coll.enabled = false;
				rend.enabled = false;
				}
			break;
		case 4: if(PlayerPrefs.GetInt ("Car4")==1)
				{
				notavailableScript.show = false;
				if(PlayerPrefs.GetInt ("ChoosenCar") != 4)
				{
					rend.enabled = true;
					coll.enabled = true;

				}else{
					coll.enabled = false;
					rend.enabled = false;
				}}else{	
				notavailableScript.show =true;
				coll.enabled = false;
				rend.enabled = false;
				}
			break;
		case 5: if(PlayerPrefs.GetInt ("Car5")==1)
				{
				notavailableScript.show = false;
				if(PlayerPrefs.GetInt ("ChoosenCar") != 5)
				{
					rend.enabled = true;
					coll.enabled = true;

				}else{
					coll.enabled = false;
					rend.enabled = false;
				}}else{	
				notavailableScript.show =true;
				coll.enabled = false;
				rend.enabled = false;
				}
			break;

		}






	}


	void OnMouseDown()
	{
		switch (moveByTouch.ChoosenObject) {
		case 1: PlayerPrefs.SetInt("ChoosenCar", moveByTouch.ChoosenObject);
			break;
		case 2: PlayerPrefs.SetInt("ChoosenCar", moveByTouch.ChoosenObject);
			break;
		case 3: PlayerPrefs.SetInt("ChoosenCar", moveByTouch.ChoosenObject);
			break;
		case 4: PlayerPrefs.SetInt("ChoosenCar", moveByTouch.ChoosenObject);
			break;
		case 5: PlayerPrefs.SetInt("ChoosenCar", moveByTouch.ChoosenObject);
			break;

		}
		Debug.Log ("The choosen car is :" + PlayerPrefs.GetInt ("ChoosenCar"));

	}
}
