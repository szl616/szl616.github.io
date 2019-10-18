using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickedUpNumber : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown()
    {
        if(transform.parent.GetComponent<PickNumber>().CheckAnswer(GetComponent<NumberProperties>().number))
        {
            Debug.Log("Correct Number Picked");
        }
        else
        {
        Debug.Log("Incorrect Number Picked");
            transform.parent.GetComponent<PickNumber>().ChangePosition();
        }
    }
}
