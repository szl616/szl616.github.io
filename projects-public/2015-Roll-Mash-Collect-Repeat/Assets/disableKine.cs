using UnityEngine;
using System.Collections;

public class disableKine : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Invoke ("Destroy", 5);
	}
	
	// Update is called once per frame
	void Update () {
	if (RemoveKinematic.EnableKine) {
			GetComponent<Rigidbody>().isKinematic = false;
		}
	}
	void Destroy ()
	{
		Destroy (gameObject);
	}
}
