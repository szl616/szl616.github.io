using UnityEngine;
using System.Collections;

public class mechanic : MonoBehaviour {
	public float speed = 1000.0F;
	
	void  Start ()
	{
		
	}
	
	void Update() {
		Vector2 dir = Vector2.zero;
		dir.x = Input.acceleration.x;
		
		
		if (dir.sqrMagnitude > 1)
			dir.Normalize();
		
		dir *= Time.deltaTime;
		GetComponent<Rigidbody2D>().AddForce(new Vector2 (dir.x * speed, 0));
	}
	
	
	
}