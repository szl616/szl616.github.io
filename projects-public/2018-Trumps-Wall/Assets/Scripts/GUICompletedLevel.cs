using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GUICompletedLevel : MonoBehaviour {
    private GameObject player;
    private Text txt;
	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        txt = GetComponent<Text>();
        txt.enabled = false;
	
	}
	
	// Update is called once per frame
	void Update () {

        if (player.GetComponent<movement>().NextLevel)
        {
            txt.enabled = true;
        }
	
	}
}
