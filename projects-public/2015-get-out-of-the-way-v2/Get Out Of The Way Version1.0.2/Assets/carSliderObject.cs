using UnityEngine;
using System.Collections;

public class carSliderObject : MonoBehaviour {
	public int CarObjectNumber = 0;
	private int CarObjectNumberA;
	private int CarObjectNumberB;
	public static bool GotIt = false;




	public Renderer rend;

	// Use this for initialization
	void Start () {

		rend = GetComponent<Renderer> ();
		CarObjectNumberA = CarObjectNumber - 1;
		CarObjectNumberB = CarObjectNumber + 1;




	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (CarObjectNumber == 0) {
			Debug.Log (" CarObjectNumber Cant be 0");
		}
		if (CarObjectNumber > moveByTouch.AmountOfObjectGlobal) {
			Debug.Log (" CarObjectNumber is too high, or Amount of object is too low");
		}


		if (moveByTouch.ChoosenObject >= CarObjectNumberA && moveByTouch.ChoosenObject <= CarObjectNumberB) {
			rend.enabled = true;



		} else {
			rend.enabled = false;

		}



	}
}
