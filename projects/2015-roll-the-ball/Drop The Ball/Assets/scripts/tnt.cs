using UnityEngine;
using System.Collections;

public class tnt : MonoBehaviour {
	public CircleCollider2D ballTouch;
	public BoxCollider2D block;
	public bool destroyBlock = false;
	public MeshRenderer rend;

	public bool exploded = false;
	// Use this for initialization
	void Start () {
		ballTouch = GetComponent<CircleCollider2D> ();
		ballTouch.enabled = false;

		block = GetComponent<BoxCollider2D> ();
		block.enabled = true;

		rend = GetComponent<MeshRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
	

	}

	void OnMouseDown () 
	{
		ballTouch.enabled = true;

		block.enabled = false;
		rend.enabled = false;



		exploded = true;

	}

	void OnMouseUp ()
	{
		if (exploded) {
		
		ballTouch.enabled = false;

		}
	}


}
