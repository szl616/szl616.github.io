using UnityEngine;
using System.Collections;

public class building : MonoBehaviour {

	Ray ray;
	RaycastHit hit;
	
	void Update()
	{
		ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		if(Physics.Raycast(ray, out hit))
		{
			print (hit.collider.name);
			if(hit.collider.tag == "buildingPlatform")
			{
			print (hit.collider.name);
				hit.collider.SendMessage("MouseHover",  SendMessageOptions.DontRequireReceiver);
			}
		}
	}

 
}
