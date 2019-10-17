using UnityEngine;
using System.Collections;

public class spawnRoad : MonoBehaviour {
	public GameObject roadPrefab;
	public float StartTime = 0F;
	public float SpawnTime = 2.0F;
	// Use this for initialization
	void Start () {
		//InvokeRepeating ("createRoad", StartTime, SpawnTime);
	}
	
	// Update is called once per frame
	void Update () {
	

	}



	void createRoad ()
	{
		Instantiate (roadPrefab, transform.position, Quaternion.identity);

	}
}
