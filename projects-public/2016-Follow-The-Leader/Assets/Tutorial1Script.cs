using UnityEngine;
using System.Collections;

public class Tutorial1Script : MonoBehaviour {

	public static int AmountOfBombGreen;
	public static int PickUpBombed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (AmountOfBombGreen == PickUpBombed) {
			Application.LoadLevel("Tutorial2");
		}

        

	}
}
