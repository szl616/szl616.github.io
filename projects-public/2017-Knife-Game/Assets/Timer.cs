using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	private Text txt;
	public bool StartTime = false;
	public float _time;

	// Use this for initialization
	void Start () {
		txt = GetComponent<Text> ();
		_time = 0;
		StartTime = false;
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonUp(0))
		{
			StartTime = true;
		}

		if (GameObject.Find ("Knife").GetComponent<FlipKnife> ().Finish) {
			StartTime = false;
		}
	
		if (StartTime) {
			_time += Time.deltaTime;
			txt.text = "" + _time.ToString ("F")+"s";
		}

	}


}
