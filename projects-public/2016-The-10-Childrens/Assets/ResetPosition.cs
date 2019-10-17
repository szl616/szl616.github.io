using UnityEngine;
using System.Collections;

public class ResetPosition : MonoBehaviour {
    public float slideBackSpeed = 10;

    private Vector3 startPosition;
    private Quaternion startRotation;
    private bool slideBack = false;
    private Rigidbody2D rb;
	// Use this for initialization
	void Start () {
        startPosition = transform.position;
        startRotation = transform.rotation;
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.R) || movePlayer.slideCamera)
        {
            rb.isKinematic = true;
            slideBack = true;

        }
        if (slideBack)
        {
            
            transform.position = Vector3.Lerp(transform.position, startPosition, 0.01F * slideBackSpeed);
            transform.rotation = Quaternion.Lerp(Quaternion.identity, startRotation, 0.01F * slideBackSpeed);
            if (Vector3.Distance(transform.position, startPosition) < 0.001F)
            {
                rb.isKinematic = false;
                slideBack = false;
            }
        }

    }
}
