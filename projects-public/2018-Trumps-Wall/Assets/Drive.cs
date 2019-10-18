using UnityEngine;
using System.Collections;

public class Drive : MonoBehaviour {
    public float driveForce = 1000;
    public bool driveEnabled = false;
    private Rigidbody rb;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        if(driveEnabled)
        rb.AddRelativeForce(Vector3.back * Time.deltaTime * driveForce*200);
    }
	
	// Update is called once per frame
	void Update () {
        if (driveEnabled)
        {
            if (transform.rotation.x < 90 || transform.rotation.x > -90 || transform.rotation.z < 52 || transform.rotation.z > -52 || transform.position.y < 10.1F)
            {
                rb.AddRelativeForce(Vector3.back * Time.deltaTime * driveForce);

            }
        }
	
	}


    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "driveEndZone")
        {

            Destroy(gameObject);
        }
    }
}
