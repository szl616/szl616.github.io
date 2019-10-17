using UnityEngine;
using System.Collections;

public class applyTntEffect : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D( Collider2D hit)
		
	{
		if (hit.gameObject.tag == "tntBlock") {
			
			Destroy (gameObject);
		}
	}
}
