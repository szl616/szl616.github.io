using UnityEngine;
using System.Collections;

public class FireballScript : MonoBehaviour {
	public float speed = 10;
	public static float damage = 50;
	public string damageType = "fireball";
	// Use this for initialization
	void Start () {
		Invoke("Kill", 10);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.up * Time.deltaTime* speed);
	}

	void Kill ()
	{
		Destroy (gameObject);
	}

	void OnTriggerEnter2D (Collider2D hit)
	{
		Destroy (gameObject);
	}
}
