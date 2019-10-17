using UnityEngine;
using System.Collections;

public class pictureScript : MonoBehaviour {
	public Material[] pictures;
	public float frameRate;
	private float counter;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


		for (int i = 0; i<pictures.Length; i++) {
			while((counter*Time.deltaTime)<frameRate);
			Instantiate(pictures[i],this.transform.position+new Vector3(0,0,-1*i), Quaternion.identity);


		}
	
	}
}
