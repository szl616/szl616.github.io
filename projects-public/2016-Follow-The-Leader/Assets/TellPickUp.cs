using UnityEngine;
using System.Collections;

public class TellPickUp : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Tutorial1Script.AmountOfBombGreen++;
		InvokeRepeating ("ShowNot", 0, 1);
		InvokeRepeating ("Show", 0.5F, 1);

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider col){
		

		if (col.gameObject.tag == "Player") {
			Tutorial1Script.PickUpBombed++;
			Destroy (gameObject);
		}
		
	}

	void Show ()
	{
		GetComponent<Renderer> ().enabled = true;
	}

	void ShowNot ()
	{
		GetComponent<Renderer> ().enabled = false;
	}
}
