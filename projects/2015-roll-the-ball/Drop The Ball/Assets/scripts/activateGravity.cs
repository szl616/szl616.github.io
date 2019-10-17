using UnityEngine;
using System.Collections;

public class activateGravity : MonoBehaviour {
	public Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		rb.isKinematic = true;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D (Collision2D hit)
	{
		if(hit.gameObject.tag == "Player")
		{
			rb.isKinematic = false;
			
		}




	}


}
