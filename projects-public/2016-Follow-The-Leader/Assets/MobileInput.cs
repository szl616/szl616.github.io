using UnityEngine;
using System.Collections;

public class MobileInput : MonoBehaviour {

	public GameObject player;

	public enum MoveDirection {left, right, up, down};

	public MoveDirection moveDirection;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (moveDirection == MoveDirection.left) {
			if(movePlayer.currentPlatform == 0 || movePlayer.currentPlatform == 4 || movePlayer.currentPlatform == 8 || movePlayer.currentPlatform == 12)
			{
				GetComponent<BoxCollider>().enabled = false;
			}else{
				GetComponent<BoxCollider>().enabled = true;
			}
		}

		if (moveDirection  == MoveDirection.right) {
			if(movePlayer.currentPlatform == 3 || movePlayer.currentPlatform == 7 || movePlayer.currentPlatform == 11 || movePlayer.currentPlatform == 15)
			{
				GetComponent<BoxCollider>().enabled = false;
			}else{
				GetComponent<BoxCollider>().enabled = true;
			}
		}

		if (moveDirection == MoveDirection.down) {
			if(movePlayer.currentPlatform == 12 || movePlayer.currentPlatform == 13 || movePlayer.currentPlatform == 14 || movePlayer.currentPlatform == 15)
			{
				GetComponent<BoxCollider>().enabled = false;
			}else{
				GetComponent<BoxCollider>().enabled = true;
			}
		}

		if (moveDirection == MoveDirection.up) {
			if(movePlayer.currentPlatform == 0 || movePlayer.currentPlatform == 1 || movePlayer.currentPlatform == 2 || movePlayer.currentPlatform == 3)
			{
				GetComponent<BoxCollider>().enabled = false;
			}else{
				GetComponent<BoxCollider>().enabled = true;
			}			
		}
	}

	void OnMouseDown ()
	{
		if (moveDirection == MoveDirection.left) {
			player.gameObject.SendMessage("MoveLeftFromMobile", SendMessageOptions.DontRequireReceiver);
		}
		
		if (moveDirection == MoveDirection.right) {
			player.gameObject.SendMessage("MoveRightFromMobile", SendMessageOptions.DontRequireReceiver);
		}
		
		if (moveDirection == MoveDirection.down) {
			player.gameObject.SendMessage("MoveDownFromMobile", SendMessageOptions.DontRequireReceiver);
		}
		
		if (moveDirection == MoveDirection.up) {
			player.gameObject.SendMessage("MoveUpFromMobile", SendMessageOptions.DontRequireReceiver);	
		}
	}
}
