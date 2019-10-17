using UnityEngine;
using System.Collections;

public class ArrowScript : MonoBehaviour {

	public Transform CarSlide;
	public bool LeftArrow = false;
	public bool RightArrow = false;


	// Use this for initialization
	void Start () {
	if (LeftArrow == RightArrow) {
			Debug.Log ("No direction for arrows have been choosen");
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnMouseDown ()
	{
		if (LeftArrow) {
			CarSlide.SendMessage ("MoveLeft");
		}

		if (RightArrow) {
			CarSlide.SendMessage ("MoveRight");
		}
	}

}
