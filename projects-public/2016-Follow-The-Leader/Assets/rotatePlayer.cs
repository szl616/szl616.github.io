using UnityEngine;
using System.Collections;

public class rotatePlayer : MonoBehaviour {
    public GameObject Arms;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

        if(movePlayer.moveLeft)
        {
            this.transform.localEulerAngles = new Vector3( 0, 0, 90);
        }

        if (movePlayer.moveRight)
        {
            this.transform.localEulerAngles = new Vector3( 0, 0, 270);
        }

        if (movePlayer.moveDown)
        {
            this.transform.localEulerAngles = new Vector3( 0, 0, 180);
        }

        if (movePlayer.moveUp)
        {
            this.transform.localEulerAngles = new Vector3( 0, 0, 0);
        }

        if(movePlayer.moveLeft || movePlayer.moveRight || movePlayer.moveDown || movePlayer.moveUp)
        {
            Arms.GetComponent<Renderer>().enabled = true;
        }
        else
        {
            Arms.GetComponent<Renderer>().enabled = false;
        }

    }
}
