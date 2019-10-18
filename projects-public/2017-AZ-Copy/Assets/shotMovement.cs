using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shotMovement : MonoBehaviour {
    public float speed;
	public float destroyTime = 10;
	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody2D> ().AddRelativeForce (Vector3.right * speed);
		Invoke ("DestroyShot", destroyTime);
    }
	
	// Update is called once per frame
	void Update () {
        

        
	}

    void OnCollisionEnter2D (Collision2D other)
    {
        if(other.gameObject.tag == "wall")
        {
          //  Destroy(gameObject);
        }

        if(other.gameObject.tag == "Player")
        {
            //Application.LoadLevel(Application.loadedLevel);
			other.gameObject.GetComponent<movement>().Kill();
			Destroy (gameObject);
        }
    }

	void DestroyShot(){
		Destroy (gameObject);
	}
}
