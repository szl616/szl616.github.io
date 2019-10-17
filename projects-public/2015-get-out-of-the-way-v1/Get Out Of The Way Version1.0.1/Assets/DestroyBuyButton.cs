using UnityEngine;
using System.Collections;

public class DestroyBuyButton : MonoBehaviour {

	private Renderer rend;	
	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer> ();
	}
	
	// Update is called once per frame
	void Update () {
	


	}




	void DestroyButton ()
	{
		Destroy (gameObject);
	}
}
