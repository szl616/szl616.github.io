using UnityEngine;
using System.Collections;

public class vehicleSpawner : MonoBehaviour {
    public GameObject[] vehicles;
    public int vehicleIndex;
    public float startTime;
    public float repeatTime;
    // Use this for initialization
    void Start () {
        InvokeRepeating("Spawn", startTime, repeatTime);
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    void Spawn()
    {

        Instantiate(vehicles[vehicleIndex], transform.position, transform.rotation);
    }
}
