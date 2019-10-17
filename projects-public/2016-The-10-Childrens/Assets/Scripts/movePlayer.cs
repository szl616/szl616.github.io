using UnityEngine;
using System.Collections;

public class movePlayer : MonoBehaviour {
    public enum Child { None,Power, Weak, Flame, Fat, Inverted, Delayed, Gelium, Lonely, Weirdo, Hash };

    public float force = 10;
    public float jumpForce = 10;
    public bool inAir = false;
    public Child childState;
  
    private GameObject camera;
    public float cameraSpeed = 10;
    private Vector3 cameraStartPosition;
    private Vector3 startPosition;

    private float startForce;
    private float startJumpForce;
    private float startWeight;


    public static bool slideCamera = false;

    private Rigidbody2D rb;
    // Use this for initialization


    
    void Start () {
        rb = GetComponent<Rigidbody2D>();

        startForce = force;
        startJumpForce = jumpForce;
        startWeight = rb.mass;

        camera = GameObject.Find("Main Camera");
        cameraStartPosition = camera.transform.position;

        
        startPosition = transform.position;
	}
	


	// Update is called once per frame
	void Update () {
        

        if (Input.GetKeyDown(KeyCode.Space) && !inAir)
        {
            rb.AddForce(Vector2.up * jumpForce);
        }

        if (slideCamera)
        {
            childState = Child.None;
            camera.transform.position = Vector3.Lerp(camera.transform.position, cameraStartPosition, 0.01F*cameraSpeed);
            if (Vector3.Distance(camera.transform.position, cameraStartPosition) < 0.01F)
            {
                rb.velocity = new Vector2(0, 0);
                rb.isKinematic = false;
                Invoke("SlideCameraBack", 0.1F);
            }
        }else
        {
            rb.AddForce(Vector2.right * Input.GetAxis("Horizontal") * force);
        }


        if (Input.GetKeyDown(KeyCode.R))
        {
            transform.position = startPosition;
            rb.isKinematic = true;
            slideCamera = true;
        }


        switch (childState)
        {
            case Child.None:
                force = startForce;
                jumpForce = startJumpForce;
                rb.mass = startWeight;
                break;
            case Child.Power:
                rb.mass = 10;
                force = 20;
                jumpForce = 4000;
                break;
        }

    }



    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag != "frameSide")
        {
            inAir = false;
        }else
        {
            inAir = true;
        }

        if(col.gameObject.tag == "Dead")
        {
            slideCamera = true;
            rb.isKinematic = true;            
            transform.position = startPosition;
            
        }
    }

    
    void OnCollisionStay2D(Collision2D col)
    {
        if (col.gameObject.tag != "frameSide")
        {
            inAir = false;
        }
    }


    void OnCollisionExit2D(Collision2D col)
    {
        inAir = true;
    }

    void OnTriggerEnter2D (Collider2D col)
    {
        
        if(col.gameObject.tag == "Goal")
        {
            Debug.Log("Next Level");
            Application.LoadLevel(Application.loadedLevel + 1);
            
        }

        if (col.gameObject.tag == "Child")
        {
            GameObject child = col.gameObject;

            switch (child.GetComponent<ChildProperties>().childState)
            {
                case ChildProperties.Child.Power:
                    childState = Child.Power;
                    break;
            }
        }
    }

    void SlideCameraBack()
    {
        slideCamera = false;
    }
}
