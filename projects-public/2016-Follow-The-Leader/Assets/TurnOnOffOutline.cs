using UnityEngine;
using System.Collections;

public class TurnOnOffOutline : MonoBehaviour {
	public Transform OutlineUp;
	public Transform OutlineRight;
	public Transform OutlineDown;
	public Transform OutlineLeft;
	// Use this for initialization
	void Start () {
	
		InvokeRepeating ("OutlineUpShow", 0, 2);
		InvokeRepeating ("OutlineRightShow", 0.5F, 2);
		InvokeRepeating ("OutlineDownShow", 1, 2);
		InvokeRepeating ("OutlineLeftShow", 1.5F, 2);

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OutlineUpShow(){

		OutlineUp.GetComponent<Renderer> ().enabled = true;
		OutlineRight.GetComponent<Renderer> ().enabled = false;
		OutlineDown.GetComponent<Renderer> ().enabled = false;
		OutlineLeft.GetComponent<Renderer> ().enabled = false;
	}

	void OutlineRightShow(){
		
		OutlineUp.GetComponent<Renderer> ().enabled = false;
		OutlineRight.GetComponent<Renderer> ().enabled = true;
		OutlineDown.GetComponent<Renderer> ().enabled = false;
		OutlineLeft.GetComponent<Renderer> ().enabled = false;
	}

	void OutlineDownShow(){
		
		OutlineUp.GetComponent<Renderer> ().enabled = false;
		OutlineRight.GetComponent<Renderer> ().enabled = false;
		OutlineDown.GetComponent<Renderer> ().enabled = true;
		OutlineLeft.GetComponent<Renderer> ().enabled = false;
	}

	void OutlineLeftShow(){
		
		OutlineUp.GetComponent<Renderer> ().enabled = false;
		OutlineRight.GetComponent<Renderer> ().enabled = false;
		OutlineDown.GetComponent<Renderer> ().enabled = false;
		OutlineLeft.GetComponent<Renderer> ().enabled = true;
	}
}
