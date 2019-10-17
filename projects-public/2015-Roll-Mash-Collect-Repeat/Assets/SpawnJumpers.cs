using UnityEngine;
using System.Collections;

public class SpawnJumpers : MonoBehaviour {
	public Transform Jumper;
	public Transform Wall;
	public float SpawnPositionStart;
	public float SpawnPositionEnd;
	public Vector3 Offset;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void SpawnJumper ()
	{
		Instantiate (Jumper, 
		            new Vector3 (Random.Range(SpawnPositionStart,SpawnPositionEnd),
		                        Offset.y,
		             transform.position.z + Offset.z ),
		            Jumper.rotation);
		if (Random.Range (0, 2) >0) {
			Instantiate (Wall, 
			             new Vector3 (3.232131F,
			             -0.46F,
			             transform.position.z + Offset.z-20 ),
			             Wall.rotation);
		}
	}
}
