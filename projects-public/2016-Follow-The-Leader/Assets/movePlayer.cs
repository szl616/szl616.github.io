using UnityEngine;
using System.Collections;

public class movePlayer : MonoBehaviour {
	public Transform[] platforms;

	public float speed = 1;
	public float Margien = 0.1F;

	public bool enableLeft;
	public bool enableRight;
	public bool enableUp;
	public bool enableDown;
	public bool disableMovement = false;

	public static bool moveLeft;
	public static bool moveRight;
	public static bool moveUp;
	public static bool moveDown;

	public bool tutorial = false;

	public int currentPlatformcounter = 0;
	public static int platformsEntered = 0;
	public static bool isDead = false;
	public static bool isDone = false;

	public static int currentPlatform;
	// Use this for initialization
	void Start () {
		isDead = false;
		disableMovement = true;
		platformsEntered = 0;
		currentPlatform = 0;
	}


	
	// Update is called once per frame
	void Update () {
		if (tutorial && platformsEntered == 5) {
			isDone = true;
		}

		if (!disableMovement) {
			if (Input.GetKey (KeyCode.RightArrow)) {
				moveRight = true;
				disableMovement = true;
				currentPlatformcounter++;
                
			}

			if (Input.GetKey (KeyCode.LeftArrow)) {
				moveLeft = true;
				disableMovement = true;
				currentPlatformcounter++;
              
            }

			if (Input.GetKey (KeyCode.UpArrow)) {
				moveUp = true;
				disableMovement = true;
				currentPlatformcounter++;
                
            }

			if (Input.GetKey (KeyCode.DownArrow)) {
				moveDown = true;
				disableMovement = true;
				currentPlatformcounter++;
                
            }

		}


		if (moveRight) {
			transform.Translate (Vector2.right * Time.deltaTime * speed);
		}
		if (moveLeft) {
			transform.Translate (Vector2.left * Time.deltaTime * speed);
		}
		if (moveUp) {
			transform.Translate (Vector2.up * Time.deltaTime * speed);
		}
		if (moveDown) {
			transform.Translate (Vector2.down * Time.deltaTime * speed);
		}

	
	}

	void MoveUpFromMobile ()
	{
		if (!disableMovement) {
			moveUp = true;
			disableMovement = true;
			currentPlatformcounter++;

		}
	}

	void MoveLeftFromMobile ()
	{
		if (!disableMovement) {
			moveLeft = true;
			disableMovement = true;
			currentPlatformcounter++;
			
		}
	}

	void MoveDownFromMobile ()
	{
		if (!disableMovement) {
			moveDown = true;
			disableMovement = true;
			currentPlatformcounter++;
			
		}
	}

	void MoveRightFromMobile ()
	{
		if (!disableMovement) {
			moveRight = true;
			disableMovement = true;
			currentPlatformcounter++;
			
		}
	}

	void UpdateEnteredPlatform (int platformNo)
	{
		currentPlatform = platformNo;
		moveRight = false;
		moveDown = false;
		moveUp = false;
		moveLeft = false;
		disableMovement = false;
		
		//Debug.Log("Entered Platform: "+currentPlatform+" - The correct platform: "+moveToPlatforms.platformEntered[currentPlatformcounter-1]);
		if(currentPlatform == moveToPlatforms.platformEntered[currentPlatformcounter-1])
		{
			platformsEntered++;

		}else{
			if(!isDead)
			GetComponent<AudioSource>().Play();
			isDead = true;
			disableMovement = true;
		}
	}

	void Die ()
	{
		if(!isDead)
		GetComponent<AudioSource>().Play();
		isDead = true;
		disableMovement = true;
	}

	void RestartLevel (){
		Application.LoadLevel (Application.loadedLevel);
	}

}
