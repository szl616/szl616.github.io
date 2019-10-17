using UnityEngine;
using System.Collections;

public class turretBullet : MonoBehaviour {
	
	public float mySpeed = 10;
	public float myRange = 50;
	//public static float damageAmount = turret.damageAmount;
	//public static string damageType = turret.damageType;
	
	private float myDist;

	private float damage;
	private string damageType;
	private float reloadTime;

	
	// Update is called once per frame
	void Update () {

		mySpeed = 10 * (5 / reloadTime);
		transform.Translate (Vector3.forward * Time.deltaTime * mySpeed);
		myDist += Time.deltaTime * mySpeed;
		if (myDist >= myRange) {
			Destroy(gameObject);
		}
		
	}
	
	void OnTriggerEnter (Collider other)
	{
		Destroy (gameObject);
		other.gameObject.SendMessage ("TakeDamage", damage, SendMessageOptions.DontRequireReceiver);
		other.gameObject.SendMessage ("TakeDamageType", damageType, SendMessageOptions.DontRequireReceiver);

	}

	void RecieveTowerDamage(float towerDamage)
	{
		damage = towerDamage;
	}

	void RecieveTowerDamageType(string towerDamageType)
	{
		damageType = towerDamageType;
	}

	void RecieveTowerReloadTime(float towerReload)
	{
		reloadTime = towerReload;
	}
}
