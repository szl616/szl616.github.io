using UnityEngine;
using System.Collections;

public class HideWhenHitByPlayer : MonoBehaviour {
    private Renderer rend;
    private CircleCollider2D collider;
	// Use this for initialization
	void Start () {
        rend = GetComponent<Renderer>();
        collider = GetComponent<CircleCollider2D>();

        rend.enabled = true;
        collider.enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
	
        if(Input.GetKeyDown(KeyCode.R) || movePlayer.slideCamera)
        {
            rend.enabled = true;
            collider.enabled = true;
        }
	}

    void OnTriggerEnter2D (Collider2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            rend.enabled = false;
            collider.enabled = false;
        }

    }
}
