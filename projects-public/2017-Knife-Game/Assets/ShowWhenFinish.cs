using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowWhenFinish : MonoBehaviour {
	public GameObject ObjectsForHide;
	// Use this for initialization
	void Start () {
		ObjectsForHide.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (GameObject.Find("Knife").GetComponent<FlipKnife>().Finish) {
			ObjectsForHide.SetActive (true);
		}

	}
}
