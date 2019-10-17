using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {

	public float speed = 1.0F;
	public bool leftBorderHit = false;
	public bool rightBorderHit = false;
	public static bool MoveLeft = false;
	public static bool MoveRight = false;

	public float leftBorderOffset = -4.26f;
	public float rightBorderOffset = 4.26f;

	public static float Health = 100.0F;

	private bool disableLeft = false;
	private bool disableRight = false;

	public static int Money = 0;
	public static bool Dead = false;



	public Material[] carsMaterial;
	public Renderer rend;

	//public float offset = 1.0F;
	//Animator anim;

	
	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer>();
		rend.enabled = true;
		Dead = false;
		Health = 100F;
		//anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {



		switch (PlayerPrefs.GetInt("ChoosenCar")) {
		case 1: rend.sharedMaterial = carsMaterial[0];
			break;
		case 2: rend.sharedMaterial = carsMaterial[1];
			break;
		case 3: rend.sharedMaterial = carsMaterial[2];
			break;
		case 4: rend.sharedMaterial = carsMaterial[3];
			break;
		case 5: rend.sharedMaterial = carsMaterial[4];
			break;

		}



		// Destroys the car when its dead
		if (Health <= 0) {
			Destroy (gameObject);
			Dead = true;

		}


		// Disable left and right move if we have reach the border
		if (transform.position.x < leftBorderOffset) {
			disableLeft = true;
		} else {
			disableLeft = false;
		}

		if (transform.position.x > rightBorderOffset) {
			disableRight = true;
		} else {
			disableRight = false;
		}

		// Moves the car left and right
		if (MoveLeft && !disableLeft) {
			transform.Translate(speed * Time.deltaTime, 0, 0);
		}
		if (MoveRight && !disableRight) {
			transform.Translate(-speed * Time.deltaTime, 0, 0);
		}
		
	}

	
}
