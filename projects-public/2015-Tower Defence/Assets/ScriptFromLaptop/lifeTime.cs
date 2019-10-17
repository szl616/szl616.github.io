using UnityEngine;
using System.Collections;

public class lifeTime : MonoBehaviour {
	public float time = 10f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if(Time.deltaTime>time)
		{
			Destroy(gameObject);
		}
	}
}
