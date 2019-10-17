using UnityEngine;
using System.Collections;

public class Projectile_Cannon : MonoBehaviour {

	public float mySpeed = 10;
	public float myRange = 10;
	public static float damageAmount = newTurret.damageAmount;

	private float myDist;
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.forward * Time.deltaTime * mySpeed);
		myDist += Time.deltaTime * mySpeed;
		if (myDist >= myRange) {
			Destroy(gameObject);
		}

	}

	void OnTriggerEnter (Collider other)
	{
		Destroy (gameObject);
		other.gameObject.SendMessage ("TakeDamage", damageAmount, SendMessageOptions.DontRequireReceiver);
	}
}
