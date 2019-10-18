using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MoneyText : MonoBehaviour {
    public Text text;
    public Vector3 PositionOffest;
    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(Screen.width / 2, 0, 0) + PositionOffest;
        text.text = "$" + PlayerStats.Money;
	}
}
