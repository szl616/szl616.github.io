using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {
    public GameObject object1;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Instantiate(object1, this.transform.position, Quaternion.identity);
    }
}
