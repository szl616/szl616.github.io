using UnityEngine;
using System.Collections;

public class DeliverPizzaZone : MonoBehaviour {
    public string WantedPizza;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter  (Collider col)
    {
        Debug.Log("Something touched me!");
        if(col.gameObject.tag == "Player")
        {
            Debug.Log("Player touched me!");
            if(Pizza.PizzaList[0] == WantedPizza)
            {
                Debug.Log("Pizza: " + Pizza.PizzaList[0] + ", has been delivered");
                Pizza.PizzaList[0] = "Delivered";
                Destroy(gameObject);
                
            }
        }
    }
}
