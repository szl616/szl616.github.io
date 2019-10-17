using UnityEngine;
using System.Collections;

public class followPlayer : MonoBehaviour {
    public GameObject player;
    public float stopAtLeft = -5;
    public float stopAtRight = 5;
	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {

        if (player.transform.position.x > stopAtLeft && player.transform.position.x < stopAtRight)
        {
            transform.position = new Vector3(player.transform.position.x, 0, -4.62F);
        }
    }
}
