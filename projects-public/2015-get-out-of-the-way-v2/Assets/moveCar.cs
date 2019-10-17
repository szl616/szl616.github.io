using UnityEngine;
using System.Collections;

public class moveCar : MonoBehaviour {
	public float speed = 10F;
	public bool Hit = false;
	public float Health = 100.0F;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(0, speed * Time.deltaTime, 0);

		if (Health <= 0) {
			PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money")+100);
			Destroy (gameObject);
		}
	
	}


	void OnTriggerEnter2D (Collider2D hit)

	{

		if (hit.gameObject.tag == "Player") {

			Destroy (gameObject);
			movement.Health -= 50;
			Debug.Log ("Health: "+movement.Health);
		}



		if (hit.gameObject.tag == "catcher") {
			if(!movement.Dead){
				//movement.Money += 100;
				PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money")+100);

				Debug.Log ("Money: "+PlayerPrefs.GetInt("Money"));

			
			}

			Destroy (gameObject);

		}

	}


	public void ApplyDamage (float damage)
	{

			Health -= damage;
		
	}
}
