using UnityEngine;
using System.Collections;

public class moveToTarget : MonoBehaviour {

	public float mySpeed = 10;

	public Transform[] target;
	public int pathNumber = 0;
	void Update() 
	{

		// Rotate object to the target
		Vector3 relativePos = target[pathNumber].position - transform.position;
		Quaternion rotation = Quaternion.LookRotation(relativePos);
		transform.rotation = rotation;

		// Move the object forward along its z axis 1 unit/second.
		transform.Translate(Vector3.forward * Time.deltaTime * mySpeed);
	}

	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.tag == "pathPoints") 
		{
			pathNumber++;
			StartCoroutine (MyMethod ());
		}

		if (other.gameObject.tag == "goal") 
		{
			Destroy(gameObject);
			Debug.Log("You lost a life");
		}

	}

	IEnumerator MyMethod() 
	{
		yield return new WaitForSeconds(2);
	}

}