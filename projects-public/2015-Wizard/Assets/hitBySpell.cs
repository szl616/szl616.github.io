using UnityEngine;
using System.Collections;

public class hitBySpell : MonoBehaviour {
	public float Health = 100;
	public Transform Target;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {



	if(Health <= 0){
			Destroy (gameObject);
		
	}else{

		Vector3 relativePos = Target.transform.position - transform.position;
		Quaternion rotation = Quaternion.LookRotation(relativePos);
		transform.rotation = rotation;

	}
	}

	void OnTriggerEnter2D (Collider2D hit)
	{
		if (hit.gameObject.tag == "damageFireball") {
			Health -= 50;
			Debug.Log(Health);
		}
	}
}
