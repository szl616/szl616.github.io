using UnityEngine;
using System.Collections;

public class bullet : MonoBehaviour {
	public float mySpeed = 10;
	public float myRange = 10;
	public GameObject target;
	public bool damageCD = false;
	public float damageAmount = 50;

	private float myDist;


	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.forward * Time.deltaTime * mySpeed);
		myDist += Time.deltaTime * mySpeed;
		if(myDist>= myRange)
		{
			Destroy(gameObject);
		}
	
	}

	void OnTriggerEnter (Collider other)
	{
		if(other.gameObject.tag == "Enemy")
		{

			Destroy(gameObject);
			other.gameObject.SendMessage("Attack",damageAmount,SendMessageOptions.DontRequireReceiver);


		}
	}


}
