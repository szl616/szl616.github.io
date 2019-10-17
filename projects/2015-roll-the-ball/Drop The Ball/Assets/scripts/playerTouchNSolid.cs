using UnityEngine;
using System.Collections;



    public class playerTouchNSolid : MonoBehaviour {
	public Material[] materials;
	public Renderer rend;
	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer>();
		rend.enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D (Collision2D hit)
	{
		if(hit.gameObject.tag == "Player")
		{
			Destroy( GetComponent<Rigidbody2D>());
			rend.sharedMaterial = materials[0];

		}
	}




}
