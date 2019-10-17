using UnityEngine;
using System.Collections;

public class buildningModeFalse : MonoBehaviour {
	public Transform buildningBack;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown()
	{
		buildningBack.gameObject.SendMessage ("EndBuildningMode", SendMessageOptions.DontRequireReceiver);
	}
}
