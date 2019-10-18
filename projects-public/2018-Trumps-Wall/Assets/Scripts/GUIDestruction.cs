using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GUIDestruction : MonoBehaviour
{
    private GameObject player;
    public Text txt;
    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {

        txt.text = "Destruction: " + player.GetComponent<movement>().CurrentDestruction.ToString("F2") + "% - Requires: " + player.GetComponent<movement>().DestructionAmount + "%";
        transform.position = new Vector3(Screen.width / 2, Screen.height-50, 0);

        if(player.GetComponent<movement>().NextLevel)
        {
            txt.color = Color.green;
        }

    }
}
