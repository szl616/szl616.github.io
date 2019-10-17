using UnityEngine;
using System.Collections;

public class PlayOnCollider : MonoBehaviour {
	public AudioClip[] bouncySound;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision hit)
	{
		if (hit.gameObject.tag == "Player") {
			GetComponent<AudioSource> ().PlayOneShot (bouncySound [Random.Range (0, bouncySound.Length)]);
		}
	}
}
