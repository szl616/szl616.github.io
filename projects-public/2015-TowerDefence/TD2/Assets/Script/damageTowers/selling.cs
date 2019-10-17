using UnityEngine;
using System.Collections;

public class selling : MonoBehaviour {
	private turret script1; 
	public GameObject tower1;

	private sellTower script2;
	public GameObject tower1Main;
	
	private Renderer rend;
	private Collider coll;
	
	
	// Use this for initialization
	void Start () {
		
		script1 = tower1.GetComponent<turret>();
		rend = GetComponent<Renderer>();
		rend.enabled = false;
		coll = GetComponent<Collider> ();
		coll.enabled = false;
		
	}
	
	// Update is called once per frame
	void Update () {
		if (script1.selected) {
			Debug.Log ("Det virker");
			rend.enabled = true;
			coll.enabled = true;
		} else {
			rend.enabled = false;
			coll.enabled = false;
		}
		
	}

	void OnMouseDown ()
	{
		tower1Main.gameObject.SendMessage ("Destroy", SendMessageOptions.DontRequireReceiver);
	}
}
