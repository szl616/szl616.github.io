using UnityEngine;
using System.Collections;

public class FollowTheBall : MonoBehaviour {
	public Transform player;
	public Vector3 Offset;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
		transform.position = player.position + Offset;

	}
}
