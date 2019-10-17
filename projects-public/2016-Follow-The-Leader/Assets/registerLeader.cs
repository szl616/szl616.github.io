using UnityEngine;
using System.Collections;

public class registerLeader : MonoBehaviour {
	public int platformNo;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider col){

		if (col.gameObject.tag == "Leader") {

			col.gameObject.SendMessage("UpdatePlatformArray", platformNo);

		}
		if (col.gameObject.tag == "Player") {
			col.gameObject.SendMessage("UpdateEnteredPlatform", platformNo);
		}

	}
}
