using UnityEngine;
using System.Collections;

public class ShowEndWhenDone : MonoBehaviour {
	public Transform endPoint;
	public float speed = 1;
	// Use this for initialization
	void Start () {
		InvokeRepeating ("Succes", 0, 2);
	}
	
	// Update is called once per frame
	void Update () {

		if (movePlayer.isDone) {
			
			//GetComponent<AudioSource>().Play();
			transform.position = Vector3.Lerp(this.transform.position, endPoint.position, speed*Time.deltaTime);

			
		}
		
	}

	void Succes ()
	{
		if (movePlayer.isDone) {
			
			GetComponent<AudioSource> ().Play ();
		}

	}
}
