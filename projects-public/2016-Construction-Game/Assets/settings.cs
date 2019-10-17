using UnityEngine;
using System.Collections;

public class settings : MonoBehaviour {

	// Use this for initialization
	void Start () {
		CarMovementScript.AmountOfBoxes++;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "Goal") {
			CarMovementScript.AmountOfBoxes--;
			Destroy (gameObject);	
		}
	}
}
