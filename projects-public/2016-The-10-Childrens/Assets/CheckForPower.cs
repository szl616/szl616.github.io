using UnityEngine;
using System.Collections;

public class CheckForPower : MonoBehaviour {
    private GameObject Player;
    private Rigidbody2D rb;

    public float setWeigth;

    private float startMass;
	// Use this for initialization
	void Start () {
        Player = GameObject.Find("Player");
        rb = GetComponent<Rigidbody2D>();
        startMass = rb.mass;
	}
	
	// Update is called once per frame
	void Update () {

        if(Player.GetComponent<movePlayer>().childState == movePlayer.Child.Power)
        {
            rb.mass = setWeigth;
        }else
        {
            rb.mass = startMass;
        }
	
	}
}
