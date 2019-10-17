using UnityEngine;
using System.Collections;

public class moveCar : MonoBehaviour {
	public float speed = 10F;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(0, speed * Time.deltaTime, 0);
	
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
				movement.Money += 100;
				Debug.Log ("Money: "+movement.Money);

			
			}

			Destroy (gameObject);

		}

	}
}
