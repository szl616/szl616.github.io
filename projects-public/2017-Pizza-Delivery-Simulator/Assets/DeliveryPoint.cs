using UnityEngine;
using System.Collections;

public class DeliveryPoint : MonoBehaviour {
    public int ChooseOrder = 1;
    public int[] Orders;
    private PlayerStats playerStats;

   
	// Use this for initialization
	void Start () {
        PlayerStats.Pizza = 0;

    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.KeypadPlus) && ChooseOrder < 5)
        {
            ChooseOrder++;
        }

        if (Input.GetKeyDown(KeyCode.KeypadMinus) && ChooseOrder > 1)
        {
            ChooseOrder--;
        }
    }

    void RecieveOrders(int number)
    {
               
    }

    void OnTriggerStay (Collider col)
    {

        if (col.gameObject.tag == "DeliveryPoint")
        {
            
            if (Input.GetKeyDown(KeyCode.Space))
            {
                
                PlayerStats.Pizza--;
                
                GameObject.Find("OrderText").SendMessage("DestroyOrder", SelectedOrder.Order);
                col.transform.parent.SendMessage("DeliverOrder", SelectedOrder.Order);
                col.GetComponent<Renderer>().enabled = false;
                col.GetComponent<CapsuleCollider>().enabled = false;

            }
        }

       


        if(col.gameObject.tag == "PizzaPickup")
        {
            if (Input.GetKeyDown(KeyCode.Space) && PlayerStats.Pizza <= 0)
            {
            GameObject.Find("OrderText").SendMessage("NewOrders");
            GameObject gameMaster = GameObject.Find("_GameMaster");
            gameMaster.GetComponent<PickDestination>().PickDest();
                
            }

        }


}

    public void OrderCorrect()
    {
        Debug.Log("Order korrekt leveret");
        PlayerStats.Money += (int)Random.Range(7, 15);
    }

    public void OrderNotCorrect()
    {
        Debug.Log("Order ikke korrekt leveret");
        PlayerStats.Money -= (int)Random.Range(7, 15);
    }
}
