using UnityEngine;
using System.Collections;

public class PickUp : MonoBehaviour {
    public Collider targetObject;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if(targetObject != null)
        {
            if (Input.GetKey(KeyCode.Mouse0))
            {
                targetObject.GetComponent<Rigidbody>().isKinematic = true;
                targetObject.transform.position = transform.position;
                targetObject.transform.rotation = transform.rotation;
            }
            else
            {
                targetObject.GetComponent<Rigidbody>().isKinematic = false;
                targetObject = null;
            }
        }
	
	}

    void OnTriggerStay (Collider col)
    {
        if(targetObject == null && col.gameObject.name != "Floor")
        targetObject = col;




       

    }

    void OnTriggerExit(Collider col)
    {
        targetObject.GetComponent<Rigidbody>().isKinematic = false;
        targetObject = null;

    }
}
