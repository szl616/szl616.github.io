using UnityEngine;
using System.Collections;

public class updateText : MonoBehaviour {
	private int currentScore;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<TextMesh> ().text = "" + movePlayer.platformsEntered;
		if (movePlayer.platformsEntered > PlayerPrefs.GetInt ("HS")) {
			PlayerPrefs.SetInt("HS", movePlayer.platformsEntered);

		}
	}
}
