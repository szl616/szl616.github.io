using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipKnife : MonoBehaviour {

    public Rigidbody rb;
    public float force = 100;
    public float torque = 30;
    private Vector2 startSwipe;
    private Vector2 endSwipe;

    private bool canSwipe = true;

	public bool Finish = false;


	// Use this for initialization
	void Start () {
        Debug.Log(transform.rotation);
	}
	
	// Update is called once per frame
	void Update () {


        if (canSwipe)
        {
            if (Input.GetMouseButtonDown(0))
            {
                startSwipe = Camera.main.ScreenToViewportPoint(Input.mousePosition);

            }

            if (Input.GetMouseButtonUp(0))
            {
                endSwipe = Camera.main.ScreenToViewportPoint(Input.mousePosition);

                Swipe();
                canSwipe = false;
            }
        }

        

	}

    void Swipe()
    {

        rb.isKinematic = false;
        Vector2 swipe = endSwipe - startSwipe;


        rb.AddForce(new Vector2(-swipe.x, swipe.y) * force, ForceMode.Impulse);
        rb.AddTorque(0f, 0f, -torque, ForceMode.Impulse);
    }

    void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "ground")
        {
            rb.isKinematic = true;
            canSwipe = true;
        }

		if (other.gameObject.tag == "Finish")
		{
			rb.isKinematic = true;
			Finish = true;
		}

        if(other.gameObject.tag == "coin")
        {
            Destroy(other.gameObject);
        }
    }
}


