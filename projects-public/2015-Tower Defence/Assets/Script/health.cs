using UnityEngine;
using System.Collections;

public class health : MonoBehaviour {
	public float Health = 100;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Health <= 0) 
		{
			Destroy(gameObject);
		}
	


	}

	void TakeDamage (float damageAmount)
	{
		
		Health -= damageAmount;
	}
}
