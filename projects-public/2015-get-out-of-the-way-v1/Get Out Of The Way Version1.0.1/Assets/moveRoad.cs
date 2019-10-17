using UnityEngine;
using System.Collections;

public class moveRoad : MonoBehaviour {
	public static float speed = 10.0F;

	// Use this for initialization
	void Start () {
		//Invoke ("DestroyRoad", 4);
		Vector3 temp = transform.position;
		speed = 10F;
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 temp = transform.position;

		transform.Translate(0, -speed * Time.deltaTime, 0);

		if (temp.y < -23) {

			transform.position = new Vector3 (transform.position.x, 38F, transform.position.z);
		}

		if (movement.Dead) {
			Invoke("SwitchToGarage",5);
			if(speed > 0)
			{
				speed -= 1.3F*Time.deltaTime;

			}
		}
	}

	void DestroyRoad ()
	{
		Destroy (gameObject);

	}

	void SwitchToGarage ()
	{
		Application.LoadLevel ("garage");

	}
}
