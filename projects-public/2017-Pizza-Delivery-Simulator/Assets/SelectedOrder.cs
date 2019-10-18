using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SelectedOrder : MonoBehaviour {
    private Text text;
    public static int Order = 1;
    public GameObject[] OrdersButton;
	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    public void OrderSelect(int OrderNo)
    {
        Order = OrderNo;
    }

    public void NewOrders()
    {
        for (int i = 0; i < OrdersButton.Length; i++)
        {
            OrdersButton[i].SetActive(true);
        }
        text.text = "Selected Order: " + Order;
    }

    public void DestroyOrder(int OrderNo)
    {
        OrdersButton[OrderNo-1].SetActive(false);
        for (int i = 0; i < OrdersButton.Length; i++)
        {
            if (OrdersButton[i].activeSelf)
            {
                Order = i + 1;
                text.text = "Selected Order: " + Order;
                return;

            }else
            {
                text.text = "No Orders Left";
            }

        }
    }
}
