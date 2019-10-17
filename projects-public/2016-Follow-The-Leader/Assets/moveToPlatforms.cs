using UnityEngine;
using System.Collections;

public class moveToPlatforms : MonoBehaviour {
	
	public float speed;
	public static int atPlatform;
	public int moveToNextPlatform;

	/*private int[] nextPlatform0 = new int[] {1,4};
	private int[] nextPlatform1 = new int[] {0,2,5};
	private int[] nextPlatform2 = new int[] {1,6,3};
	private int[] nextPlatform3 = new int[] {2,7};
	private int[] nextPlatform4 = new int[] {0,5,8};
	private int[] nextPlatform5 = new int[] {1,4,6,9};
	private int[] nextPlatform6 = new int[] {2,5,7,10};
	private int[] nextPlatform7 = new int[] {3,6,11};
	private int[] nextPlatform8 = new int[] {4,9,12};
	private int[] nextPlatform9 = new int[] {5,8,10,13};
	private int[] nextPlatform10 = new int[] {6,9,11,14};
	private int[] nextPlatform11 = new int[] {7,10,15};
	private int[] nextPlatform12 = new int[] {8,13};
	private int[] nextPlatform13 = new int[] {9,12,14};
	private int[] nextPlatform14 = new int[] {10,13,15};
	private int[] nextPlatform15 = new int[] {11,14};*/

	private int[] nextPlatform0 = new int[] {1,2};
	private int[] nextPlatform1 = new int[] {1,2,3};
	private int[] nextPlatform2 = new int[] {1,2,3};
	private int[] nextPlatform3 = new int[] {2,3};
	private int[] nextPlatform4 = new int[] {0,1,2};
	private int[] nextPlatform5 = new int[] {0,1,2,3};
	private int[] nextPlatform6 = new int[] {0,1,2,3};
	private int[] nextPlatform7 = new int[] {0,2,3};
	private int[] nextPlatform8 = new int[] {0,1,2};
	private int[] nextPlatform9 = new int[] {0,1,2,3};
	private int[] nextPlatform10 = new int[] {0,1,2,3};
	private int[] nextPlatform11 = new int[] {0,2,3};
	private int[] nextPlatform12 = new int[] {0,1};
	private int[] nextPlatform13 = new int[] {0,1,3};
	private int[] nextPlatform14 = new int[] {0,1,3};
	private int[] nextPlatform15 = new int[] {0,3};

	public static bool moveLeft;
	public static bool moveRight;
	public static bool moveUp;
	public static bool moveDown;

	public static int[] platformEntered = new int[1000];
	public int platformEnteredCounter = 0;

	// Use this for initialization
	void Start () {
		//InvokeRepeating ("RandomCheck", 0, 0.1F);
		moveRight = true;
        moveLeft = false;
        moveUp = false;
        moveDown = false;
	}

	void RandomCheck()
	{
		moveToNextPlatform = nextPlatform0 [Random.Range (0, nextPlatform0.Length)];
		Debug.Log (moveToNextPlatform);
	}


	// Update is called once per frame
	void Update () {

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



	void UpdatePlatformArray (int platformNo){
			platformEntered [platformEnteredCounter] = platformNo;
			//Debug.Log ("Correct Platform is: " + platformEntered [platformEnteredCounter]);
			platformEnteredCounter++;
		
		moveRight = false;
		moveDown = false;
		moveUp = false;
		moveLeft = false;
		
		switch (platformNo) {
		case 0:
			moveToNextPlatform = nextPlatform0 [Random.Range (0, nextPlatform0.Length)];
			break;
		case 1:
			moveToNextPlatform = nextPlatform1 [Random.Range (0, nextPlatform1.Length)];
			break;
		case 2:
			moveToNextPlatform = nextPlatform2 [Random.Range (0, nextPlatform2.Length)];
			break;
		case 3:
			moveToNextPlatform = nextPlatform3 [Random.Range (0, nextPlatform3.Length)];
			break;
		case 4:
			moveToNextPlatform = nextPlatform4 [Random.Range (0, nextPlatform4.Length)];
			break;
		case 5:
			moveToNextPlatform = nextPlatform5 [Random.Range (0, nextPlatform5.Length)];
			break;
		case 6:
			moveToNextPlatform = nextPlatform6 [Random.Range (0, nextPlatform6.Length)];
			break;
		case 7:
			moveToNextPlatform = nextPlatform7 [Random.Range (0, nextPlatform7.Length)];
			break;
		case 8:
			moveToNextPlatform = nextPlatform8 [Random.Range (0, nextPlatform8.Length)];
			break;
		case 9:
			moveToNextPlatform = nextPlatform9 [Random.Range (0, nextPlatform9.Length)];
			break;
		case 10:
			moveToNextPlatform = nextPlatform10 [Random.Range (0, nextPlatform10.Length)];
			break;
		case 11:
			moveToNextPlatform = nextPlatform11 [Random.Range (0, nextPlatform11.Length)];
			break;
		case 12:
			moveToNextPlatform = nextPlatform12 [Random.Range (0, nextPlatform12.Length)];
			break;
		case 13:
			moveToNextPlatform = nextPlatform13 [Random.Range (0, nextPlatform13.Length)];
			break;
		case 14:
			moveToNextPlatform = nextPlatform14 [Random.Range (0, nextPlatform14.Length)];
			break;
		case 15:
			moveToNextPlatform = nextPlatform15 [Random.Range (0, nextPlatform15.Length)];
			break;
		}
		
		switch(moveToNextPlatform){
		case 0: moveUp = true;
			break;
		case 1: moveRight = true;
			break;
		case 2: moveDown = true;
			break;
		case 3: moveLeft = true;
			break;
		}



	}
}
