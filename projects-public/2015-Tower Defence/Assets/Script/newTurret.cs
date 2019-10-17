using UnityEngine;
using System.Collections;

public class newTurret : MonoBehaviour {
	public Transform target;
	public Transform ball;
	public Transform theBullet;
	public Transform muzzlePos;
	public GameObject muzzleEffect;
	public float reloadTime = 5;
	public static float damageAmount = 100;

	private float nextFireTime;
	private bool CD = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (target) 
		{
			if(target.gameObject.tag == "Enemy")
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

	void FireProjectile()
	{
		nextFireTime = Time.time+reloadTime;

			Instantiate(theBullet, muzzlePos.position, muzzlePos.rotation);
		
	}


	void OnTriggerEnter (Collider other)
	{
		target = other.transform;
	}

	void OnTriggerExit (Collider other)
	{
		target = null;
	}

	IEnumerator MyMethod() 
	{
		yield return new WaitForSeconds(2);
	}
}
