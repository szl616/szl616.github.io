using UnityEngine;
using System.Collections;

public class CounterDown : MonoBehaviour {
	public bool startTimer;
	public int timer = 9;
	private int seconds;
	private float miliseconds;

	// Use this for initialization
	void Start () {
		startTimer = false;
		seconds = timer;
	}
	
	// Update is called once per frame
	void Update () {
	
		if (startTimer) {
			miliseconds -= Time.deltaTime*100;
			if(miliseconds < 0)
			{
				seconds--;
					miliseconds = 99;
			}

		}
		if (miliseconds < 9) {
			GetComponent<TextMesh> ().text = "" + seconds + ":0" + miliseconds.ToString("F0");
		} else {
			GetComponent<TextMesh> ().text = "" + seconds + ":" + miliseconds.ToString("F0");
		}

		if(seconds < 0)
		{
			startTimer = false;
			miliseconds = 0;
			seconds = 0;
			GameObject.FindGameObjectWithTag("Player").SendMessage("Die",SendMessageOptions.DontRequireReceiver);

		}
	}

	void OnTriggerEnter (Collider col){
		if (col.gameObject.tag == "Player") {
			startTimer = true;
			miliseconds = 99;
			seconds--;
			if(!movePlayer.isDead)
			GetComponent<AudioSource>().Play();
		}

	}

	void OnTriggerExit ( Collider col){
		if (col.gameObject.tag == "Player") {
			startTimer = false;
			Invoke("ResetTimer", 2);
			GetComponent<AudioSource>().Stop();
		}
	}

	void ResetTimer ()
	{
		seconds = timer;
		miliseconds = 0;
	}
}
