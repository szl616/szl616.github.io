using UnityEngine;
using System.Collections;

public class CheckForMovement : MonoBehaviour {
    public Vector3 startPosition;
    private GameObject player;
    public float TriggerDistance = 2;
    public bool HaveMoved = true;
	// Use this for initialization
	void Start () {
        HaveMoved = true;
        Invoke("GetPosition", 3);
        player = GameObject.FindGameObjectWithTag("Player");
        player.SendMessage("ImBrick");
    }
	
	// Update is called once per frame
	void Update () {
	
        if(Vector3.Distance(startPosition, transform.position) >= TriggerDistance && !HaveMoved)
        {
            player.SendMessage("BrickMoved");
            HaveMoved = true;

        }

	}

    void GetPosition()
    {
        startPosition = transform.position;
        HaveMoved = false;
    }
}
