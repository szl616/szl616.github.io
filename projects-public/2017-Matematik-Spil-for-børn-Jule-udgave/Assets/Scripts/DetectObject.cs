using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectObject : MonoBehaviour {

    private GameObject GO_ToDetect;
	public bool correctGO = false;
    public GameObject NextLevel;

	// Use this for initialization
	void Start () {
        NextLevel.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        if (correctGO)
        {
            GO_ToDetect.GetComponent<Collider>().enabled = false;
            GO_ToDetect.transform.position = transform.position + new Vector3(0, 0, -1);
        }
	}

    void OnTriggerEnter(Collider other)
    {
      
        if (transform.parent.GetComponent<PlusOpgave>().CheckAnswer(other.gameObject.GetComponent<NumberProperties>().number))
        {
            GO_ToDetect = other.gameObject;
            NextLevel.SetActive(true);
            correctGO = true;
        }
       
    }
}
