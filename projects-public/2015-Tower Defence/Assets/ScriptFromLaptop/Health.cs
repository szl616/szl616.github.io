using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {
	public float health = 100;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if(0>=health)
		{
			Destroy (gameObject);
		}

	}

	public void Attack(float Damage)
	{
		health -= Damage;

	}
}
