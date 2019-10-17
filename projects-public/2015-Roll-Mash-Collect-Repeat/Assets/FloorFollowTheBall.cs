using UnityEngine;
using System.Collections;

public class FloorFollowTheBall : MonoBehaviour {
	public Transform player;
	public Vector3 Offset;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.position = new Vector3(player.position.x,-4,player.position.z);
		
	}
}
