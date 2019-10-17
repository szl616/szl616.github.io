using UnityEngine;
using System.Collections;

public class ParkingSettings : MonoBehaviour {
    public bool canGetTicket;

    public bool touchingCurb;
    public bool outOfTime;
    public bool inBooth;
    public bool touchingMarkedCurb;
    public bool tooCloseToCrossSection;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter (Collider col)
    {
        //if(col.gameObject.tag == "")
    }
}
