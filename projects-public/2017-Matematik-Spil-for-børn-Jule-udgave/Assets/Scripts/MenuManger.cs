using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuManger : MonoBehaviour {

	public int page = 0;
	public Text[] menuButtons;


	// Use this for initialization
	void Start () {
		UpdateMenuNumbers ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void PageRight(){
		if (page < 10) {
			page++;
			UpdateMenuNumbers ();
		}
	}


	public void PageLeft(){
		if (page > 0) {
			page--;
			UpdateMenuNumbers ();
		}

	}

	void UpdateMenuNumbers(){

		for (int i = 0; i < 9; i++) {
			menuButtons [i].text = (page * 9 + i+1).ToString();
		}

	}
}
