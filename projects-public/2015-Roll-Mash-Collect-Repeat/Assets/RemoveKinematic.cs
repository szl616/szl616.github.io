using UnityEngine;
using System.Collections;

public class RemoveKinematic : MonoBehaviour {
	public static bool EnableKine = false;
	// Use this for initialization
	void Start () {
		EnableKine = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider hit)
	{
		if (hit.gameObject.tag == "Player") {
			EnableKine = true;
		}
	}


}
