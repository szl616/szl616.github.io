using UnityEngine;
using System.Collections;

public class changeMaterial : MonoBehaviour {

	public Material[] materials;
	public float changeInterval = 0.33f;
	public Renderer rend;
	public bool MouseDown = false;
	public int index = 0;
	public GameObject building1;

	void Start() {
		rend = GetComponent<Renderer>();
		rend.enabled = true;
	}
	void Update() {
		if (!MouseDown) 
		{
			rend.sharedMaterial = materials [2];
		}
	}

	void MouseHover ()
	{
		if (!MouseDown) 
		{
			rend.sharedMaterial = materials [0];
		}
	}

	void OnMouseDown ()
	{
		if (PlayerSettings.Money >= 300) 
		{
			MouseDown = true;
			rend.sharedMaterial = materials [1];
			Instantiate (building1, transform.position, Quaternion.identity);
			PlayerSettings.Money -= 300;
		}
	}

	void OnMouseUp ()
	{
		MouseDown = false;
	}





}
