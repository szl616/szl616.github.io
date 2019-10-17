using UnityEngine;
using System.Collections;

public class SpawnNextJumper : MonoBehaviour {

	// Use this for initialization


	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider hit)
	{
		if (hit.gameObject.tag == "Player") {
			hit.gameObject.SendMessage("SpawnJumper",SendMessageOptions.DontRequireReceiver);
		}

	}


}
