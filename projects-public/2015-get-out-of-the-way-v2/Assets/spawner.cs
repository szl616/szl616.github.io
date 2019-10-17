using UnityEngine;
using System.Collections;

public class spawner : MonoBehaviour {
	public Transform[] streetSpawn;
	public int streetSpawnInt;

	public Transform[] carSpawn;
	public int carSpawnInt1;
	public int carSpawnInt2;
	public int carSpawnInt3;

	public Transform[] carsEnemies;
	public int carsEnemiesInt;

	private int counter = 0;
	private float LowerTimer = 0;



	public bool spawn3 = false;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("createCar", 0, 2-LowerTimer);
		Invoke("enableSpawn3", 10);

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void createCar ()
	{
		if (!movement.Dead) {
			counter++;

			if (!spawn3) {
				carSpawnInt1 = Random.Range (0, 3);
				while ((carSpawnInt2 = Random.Range (0,3)) == carSpawnInt1)
					;
			} else {
				carSpawnInt1 = 0;
				carSpawnInt2 = 1;
				carSpawnInt3 = 2;
			}

			Instantiate (carsEnemies [0], carSpawn [carSpawnInt1].position, carSpawn [carSpawnInt1].rotation);
			Instantiate (carsEnemies [0], carSpawn [carSpawnInt2].position, carSpawn [carSpawnInt2].rotation);	
			if (spawn3) {
				Instantiate (carsEnemies [0], carSpawn [carSpawnInt3].position, carSpawn [carSpawnInt3].rotation);
			}

		
		}
	}

	void enableSpawn3 ()
	{
		spawn3 = true;
	}
}
