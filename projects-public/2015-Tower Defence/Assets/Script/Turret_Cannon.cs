using UnityEngine;
using System.Collections;

public class Turret_Cannon : MonoBehaviour {
	
	//Variabler start--------------------------------------------------------
	public GameObject myProjectile;
	
	public float reloadTime = 1f;
	public float turnSpeed = 5f;	
	public float firePauseTime = 25f;	
	public GameObject muzzleEffect;	
	public float errorAmount = 001f;	
	public Transform myTarget;	
	public Transform[] muzzlePositions;	
	public Transform turretBall;	
	
	private float nextFireTime;	
	private float nextMoveTime;	
	private Quaternion desiredRotation;	
	private float aimError;
	//Variabler end----------------------------------------------------------
	
	
	// Update is called once per frame
	void Update ()
	{
		
		if(myTarget)
		{
			Debug.Log ("Time: "+Time.time+"  "+"nextFireTime: "+nextFireTime);
			if(Time.time >= nextMoveTime)
			{
				CalculateAimPosition(myTarget.position);
				turretBall.rotation = Quaternion.Lerp(turretBall.rotation, desiredRotation, Time.deltaTime*turnSpeed);
			}
			
			if(Time.time >= nextFireTime	)
			{
				FireProjectile();
			}
		}
	}  
	
	
	void OnTriggerStay(Collider other)
	{
		if (!myTarget) {
			
			if (other.gameObject.tag == "Enemy") {
				nextFireTime = Time.time + (reloadTime * 1f);
				myTarget = other.gameObject.transform;
			}
		}
	}
	
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Enemy")
		{
			nextFireTime = Time.time;//+(reloadTime*5f);
			myTarget = other.gameObject.transform;
		}
	}
	
	
	
	void OnTriggerExit(Collider other)
	{
		if(other.gameObject.transform == myTarget)
		{
			myTarget = null;
		}
	}
	
	void CalculateAimPosition(Vector3 targetPos)
	{
		Vector3 aimPoint = new Vector3(targetPos.x+aimError, targetPos.y+aimError, targetPos.z+aimError);
		desiredRotation = Quaternion.LookRotation(aimPoint);
	}
	
	void CalculateAimError()
	{
		aimError = Random.Range(-errorAmount,errorAmount);
	}
	
	void FireProjectile()
	{
		
		nextFireTime = Time.time+reloadTime;
		nextMoveTime = Time.time+firePauseTime;
		CalculateAimError();
		
		foreach(Transform theMuzzlePos in muzzlePositions)
		{
			Instantiate(myProjectile, theMuzzlePos.position, theMuzzlePos.rotation);
			Instantiate(muzzleEffect, theMuzzlePos.position, theMuzzlePos.rotation);
		}
	}
}
