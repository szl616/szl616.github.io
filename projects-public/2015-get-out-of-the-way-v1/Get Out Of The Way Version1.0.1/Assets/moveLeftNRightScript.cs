using UnityEngine;
using System.Collections;

public class moveLeftNRightScript : MonoBehaviour {
	public bool LeftMovement = false;
	public bool RightMovement = false;
	// Use this for initialization
	void Start () {
	if (!LeftMovement && !RightMovement) {
			Debug.Log ("The button is not assigned to any movement");
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown ()
	{
		if (LeftMovement) {
			movement.MoveLeft = true;
		}
		if (RightMovement) {
			movement.MoveRight = true;
		}
	}
	void OnMouseUp ()
	{
		if (LeftMovement) {
			movement.MoveLeft = false;
		}
		if (RightMovement) {
			movement.MoveRight = false;
		}

	}
}
