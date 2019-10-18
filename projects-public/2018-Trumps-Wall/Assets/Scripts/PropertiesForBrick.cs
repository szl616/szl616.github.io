using UnityEngine;
using System.Collections;

public class PropertiesForBrick : MonoBehaviour {
    private Rigidbody rb;
    private GameObject player;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true;

        player = GameObject.FindGameObjectWithTag("Player");

        
	
	}
	
	// Update is called once per frame
	void Update () {
	if(player.transform.position.z > -7)
            rb.isKinematic = false;
    }

    void ActivateKinematic ()
    {
        

    }
}
