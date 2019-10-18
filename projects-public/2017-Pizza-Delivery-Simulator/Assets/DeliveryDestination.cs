using UnityEngine;
using System.Collections;

public class DeliveryDestination : MonoBehaviour {

    public int OrderID;

    public string StreetName;
    public string HouseNumber;

    public GameObject DeliveryPrefab;
    public Transform DeliveryPointSpawn;

    private GameObject deliveryPoint;
    // Use this for initialization
    void Start () {
        deliveryPoint = (GameObject)Instantiate(DeliveryPrefab, DeliveryPointSpawn.position, Quaternion.identity);
        deliveryPoint.transform.parent = this.transform;
        deliveryPoint.GetComponent<CapsuleCollider>().enabled = false;
        deliveryPoint.GetComponent<Renderer>().enabled = false;

        

    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public string TellAddress()
    {
        return StreetName + " " + HouseNumber;
        
    }

    void DeliveryPointActivate(int Order)
    {
        OrderID = Order;
        deliveryPoint.GetComponent<CapsuleCollider>().enabled = true;
        deliveryPoint.GetComponent<Renderer>().enabled = true;
        object[] tempStorage = new object[2];
        tempStorage[0] = StreetName + " " + HouseNumber;
        tempStorage[1] = OrderID;
        GameObject.Find("AddressText").SendMessage("TellAddres", tempStorage);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(DeliveryPointSpawn.position, 2.5F);
    }

    void DeliverOrder(int Order)
    {
        if(Order == OrderID)
        {
            GameObject.Find("Car").SendMessage("OrderCorrect");
        }else
        {
            GameObject.Find("Car").SendMessage("OrderNotCorrect");
        }
    }
}
