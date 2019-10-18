using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberProperties : MonoBehaviour {

	public int number;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<Text>().text = number.ToString();
    }
}
