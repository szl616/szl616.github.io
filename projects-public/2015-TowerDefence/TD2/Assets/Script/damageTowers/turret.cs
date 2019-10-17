using UnityEngine;
using System.Collections; 

public class turret : MonoBehaviour {
	//Objects
	public Transform target;
	public Transform ball;
	public Transform theBullet;
	public Transform muzzlePos;
	public GameObject muzzleEffect;
	private Transform currentBullet;

	//Damage setings
	public float reloadTime = 5; // Attack Speed	
	public float damageAmount = 100; // Attack Damage
	public bool damageTypeNormal = false;
	public bool damageTypeFire = false;
	public bool damageTypeElectric = false;
	public bool damageTypeWater = false;
	public bool damageTypePosion = false;
	public bool damageTypeMissle = false;
	public bool damageTypeLaser = false;
	private string damageType;
	private float nextFireTime;

	//Building
	public bool canUpgrade = false;
	public int buildPrice = 200;


	//Selecting
	public bool selected = false;
	public bool mouseOnObject = false;
	public bool objectSelected = false;

	//GUI Icons
	public bool canSpawnGUI = true;

	public Transform iconUpgrade;
	public Transform iconSell;
	public Transform iconBack;

	public bool test = false;

	//Selling
	//public Transform sellingGUI;




	// Use this for initialization
	void Start () {
		// Setting the damageType String
		if (damageTypeNormal) {
			damageType = "normal";
		}
		if (damageTypeFire) {
			damageType = "fire";
		}
		if (damageTypeElectric) {
			damageType = "electric";
		}
		if (damageTypeWater) {
			damageType = "water";
		}
		if (damageTypePosion) {
			damageType = "posion";
		}
		if (damageTypeMissle) {
			damageType = "missle";
		}
		if (damageTypeLaser) {
			damageType = "laser";
		}
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetButtonDown("Fire1") && !mouseOnObject)
		{
			objectSelected = false;
			selected = false;
		}


		if (!selected) {


			canSpawnGUI = true;




		}



		if (target) 
		{
			if(target.gameObject.tag == "enemy")
			{
				// Rotate object to the target
				Vector3 relativePos = target.position - transform.position;
				Quaternion rotation = Quaternion.LookRotation (relativePos);
				ball.transform.rotation = rotation;
			}
			
			if(Time.time >= nextFireTime	)
			{
				FireProjectile();
			}
		}
		
	}
	/* -Start- Finding targets*/
	void OnTriggerStay (Collider other)
	{
		if (!target) 
		{
			if(other.gameObject.tag == "Enemy")
			{
				nextFireTime = Time.time+reloadTime;
				target = other.gameObject.transform;
			}
		}
		
	}

	void OnMouseEnter()
	{
		mouseOnObject = true;
	}
	
	void OnMouseExit()
	{
		mouseOnObject = false;
	}

	void OnTriggerEnter (Collider other)
	{
		target = other.transform;
	}
	
	void OnTriggerExit (Collider other)
	{
		target = null;
	}

	/* -End- Finding targets */


	void FireProjectile()
	{
		nextFireTime = Time.time+reloadTime;
		currentBullet = (Instantiate(theBullet, muzzlePos.position, muzzlePos.rotation) as Transform).transform;
		currentBullet.gameObject.SendMessage ("RecieveTowerDamage", damageAmount, SendMessageOptions.DontRequireReceiver);
		currentBullet.gameObject.SendMessage ("RecieveTowerDamageType", damageType, SendMessageOptions.DontRequireReceiver);
		currentBullet.gameObject.SendMessage ("RecieveTowerReloadTime", reloadTime, SendMessageOptions.DontRequireReceiver);
	}
	
	


	void OnMouseDown ()
	{
		objectSelected = true;
		selected = true;

		if (canSpawnGUI) {

			canSpawnGUI = false;
		}

		//SendMessage("ShowIcon", SendMessageOptions.DontRequireReceiver);
	}



	void sell ()
	{
		Destroy (gameObject);
	}

	IEnumerator MyMethod() 
	{
		yield return new WaitForSeconds(2);
	}
}
