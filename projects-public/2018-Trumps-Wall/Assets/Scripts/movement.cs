using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {
    public float Force = 1000;
    public float pushForce = 100;
    public float angle = 45;
    public float DestructionAmount = 30;
    public float CurrentDestruction;
    public float AmountOfBricks;
    public float BrickHaveMoved;
    public bool NextLevel = false;

    public bool HaveBeenPush = false;
    private Rigidbody rb;
	// Use this for initialization
	void Start () {
        
        rb = GetComponent<Rigidbody>();
        
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Space) && !HaveBeenPush)
        {
            Push();
        }


        if (Input.GetKey(KeyCode.KeypadPlus) && angle <45)
        {
            angle += 0.1F;
        }

        if (Input.GetKey(KeyCode.KeypadMinus) && angle > 0)
        {
            angle -= 0.1F;
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Application.LoadLevel(Application.loadedLevel);
        }



        rb.AddForce(Vector3.left * Input.GetAxis("Horizontal") * -Force);
        //rb.AddForce(Vector3.forward * Input.GetAxis("Vertical") * Force);

        CurrentDestruction = (BrickHaveMoved / AmountOfBricks)*100;

        if (CurrentDestruction > DestructionAmount)
        {
            NextLevel = true;
        }else
        {
            Debug.Log("Amount of Destruction: " + ((BrickHaveMoved / AmountOfBricks) * 100) + "%");
        }

    }

    void Push()
    {
        HaveBeenPush = true;
        Debug.Log("Y værdi: " + Mathf.Tan(angle * (Mathf.PI / 180)));
       rb.AddForce(new Vector3(0, Mathf.Tan(angle*(Mathf.PI/180)), 1) * pushForce);
    }

    void ImBrick()
    {
        AmountOfBricks++;
    }

    void BrickMoved()
    {
        BrickHaveMoved++;
    }


}
