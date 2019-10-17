using UnityEngine;
using System.Collections;

public class DestroyAfterTime : MonoBehaviour {
	public float TimeToDestroy = 5;
	// Use this for initialization
	void Start () {
		Invoke ("Destroy", TimeToDestroy);
	}
	void Destroy ()
	{
		Destroy (gameObject);
	}
}
