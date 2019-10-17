using UnityEngine;
using System.Collections;

public class Pizza : MonoBehaviour {
    static public string[] PizzaList;
	// Use this for initialization
	void Start () {
        PizzaList = new string[1000];
        PizzaList[0] = "1234";
	}

    // Update is called once per frame
    void Update()
    {
    }

    void EnterCar ()
    {
        Destroy(gameObject);
    }      
}
