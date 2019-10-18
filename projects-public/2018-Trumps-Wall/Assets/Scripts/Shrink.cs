using UnityEngine;
using System.Collections;

public class Shrink : MonoBehaviour {
    public float shrinkFactor = 0.2f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player" )
        {
            col.gameObject.transform.localScale = new Vector3(shrinkFactor, shrinkFactor, shrinkFactor);
            Destroy(gameObject);
        }
    }
}
