using UnityEngine;
using System.Collections;

public class BouncyUp : MonoBehaviour {
	public float JumpForce;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter (Collision hit)
	{
		hit.gameObject.SendMessage ("Jump",JumpForce, SendMessageOptions.DontRequireReceiver);
	}
}
