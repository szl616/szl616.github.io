using UnityEngine;
using System.Collections;

public class ShowEndSceneWhenDead : MonoBehaviour {
	public Transform endPoint;
	public float speed = 1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (movePlayer.isDead) {


			transform.position = Vector3.Lerp(this.transform.position, endPoint.position, speed*Time.deltaTime);

		}

	}
}
