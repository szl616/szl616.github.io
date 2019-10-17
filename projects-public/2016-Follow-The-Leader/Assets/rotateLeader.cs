using UnityEngine;
using System.Collections;

public class rotateLeader : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (moveToPlatforms.moveLeft)
        {
            this.transform.localEulerAngles = new Vector3(0, 0, 90);
        }

        if (moveToPlatforms.moveRight)
        {
            this.transform.localEulerAngles = new Vector3(0, 0, 270);
        }

        if (moveToPlatforms.moveDown)
        {
            this.transform.localEulerAngles = new Vector3(0, 0, 180);
        }

        if (moveToPlatforms.moveUp)
        {
            this.transform.localEulerAngles = new Vector3(0, 0, 0);
        }
    }
}
