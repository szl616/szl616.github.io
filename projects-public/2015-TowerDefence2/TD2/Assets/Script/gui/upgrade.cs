using UnityEngine;
using System.Collections;

public class upgrade : MonoBehaviour {

	private Renderer rend;
	private Collider coll;
	public Transform MainObject;
	public Transform UpgradeTower;

	// Use this for initialization
	void Start ()
	{
		rend = GetComponent<Renderer>();
		rend.enabled = false;
		coll = GetComponent<Collider> ();
		coll.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
	



	}

	void OnMouseDown ()

	{
		Instantiate(UpgradeTower, MainObject.position, MainObject.rotation);
		MainObject.gameObject.SendMessage ("Destroy", SendMessageOptions.DontRequireReceiver);

	}



}
