using UnityEngine;
using System.Collections;

public class testBallSettings : MonoBehaviour {
	public float speed = 10.0F;
	public float Damage = 50.0F;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.Translate(0, speed * Time.deltaTime, 0);
	
	}

	void OnTriggerEnter2D (Collider2D hit)
		
	{
		if (hit.gameObject.tag == "enemy") {
			//hit.gameObject.SendMessage("ApplyDamage", Damage, SendMessageOptions.DontRequireReceiver);

			if(hit.gameObject.GetComponent<moveCar>() != null)
			{
				hit.gameObject.GetComponent<moveCar>().ApplyDamage(Damage);
				Destroy (gameObject);
			}

		}
		
		
	
		
	}
}
