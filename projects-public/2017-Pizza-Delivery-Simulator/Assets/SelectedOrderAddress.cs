using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SelectedOrderAddress : MonoBehaviour {
    private Text text;
    private Text[] Address = new Text[5];
	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {

        switch (SelectedOrder.Order)
        {
            case 1: text.text = Address[1].text;
                break;
            case 2: text.text = Address[2].text;
                break;
            case 3: text.text = Address[3].text;
                break;
            case 4: text.text = Address[4].text;
                break;
            case 5: text.text = Address[5].text;
                break;

        }
	
	}

    public void TellAddres(object args)
    {
        object[] a = (object[])args;
        string CollectedAddres = (string)a[0];
        int Order = (int)a[1];



        Address[Order + 1].text = CollectedAddres;
    }
}
