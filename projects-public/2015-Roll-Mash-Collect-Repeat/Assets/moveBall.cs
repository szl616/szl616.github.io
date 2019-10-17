using UnityEngine;
using System.Collections;

public class moveBall : MonoBehaviour {
	public float speed = 1;
	public float speedLimit;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("AddForce", 0, 0.05F);
	}
	
	// Update is called once per frame
	void Update () {
	

		GetComponent<Rigidbody> ().AddForce (new Vector3 (Input.acceleration.x  * speed*4, 0, 0));

		Debug.Log (GetComponent<Rigidbody>().velocity.magnitude);
	}

	void AddForce ()
	{
		if (GetComponent<Rigidbody> ().velocity.magnitude <= speedLimit) {
			GetComponent<Rigidbody> ().AddForce (new Vector3 (0, 0, speed));
		}
	}

	void Jump (float JumpForce)
	{
		GetComponent<Rigidbody> ().AddForce (new Vector3 (0, JumpForce, 0));
	}

	void OnCollisionEnter (Collision hit)
	{
		if (hit.gameObject.tag == "floor") {
			Application.LoadLevel(Application.loadedLevel);
		}
	}
}
