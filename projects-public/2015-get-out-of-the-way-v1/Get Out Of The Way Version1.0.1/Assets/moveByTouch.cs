using UnityEngine;
using System.Collections;

public class moveByTouch : MonoBehaviour {
	private Vector3 pos;
	private bool EnableTouch = false;
	public bool active = false;
	public float MoveSlider = 1.2F;
	public static int ChoosenObject = 1;
	public int AmountOfObject = 5;
	public static int AmountOfObjectGlobal = 10;
	public float numberOffsetX = 0F;
	public float numberOffsetY = 0.88F;
	public float numberOffsetZ = 0F;


	// Use this for initialization
	void Start () {
		Screen.sleepTimeout = SleepTimeout.NeverSleep;
		AmountOfObjectGlobal = AmountOfObject;
		transform.position = new Vector3 (numberOffsetX, numberOffsetY, numberOffsetZ);
		ChoosenObject = 1;
	}
	
	// Update is called once per frame
	void Update () {
		//MoveUpdate ();
	}



	void OnMouseDown()
	{
		EnableTouch = true;
		//Destroy (gameObject);
	}

	void OnMouseUp()
	{
		EnableTouch = false;
	}



	void MoveLeft ()
	{
		if (active && ChoosenObject > 1) {
			transform.Translate (MoveSlider, 0, 0);
			ChoosenObject--;
		}
	}

	void MoveRight ()
	{
		if (active &&  ChoosenObject < AmountOfObject) {
			transform.Translate (-MoveSlider, 0, 0);
			ChoosenObject++;
		}
	}

	/*void MoveUpdate()
	{
		if (Application.platform == RuntimePlatform.Android ) {

			pos = Camera.main.ScreenToWorldPoint (new Vector3 (Input.GetTouch (0).position.x,Input.GetTouch (0).position.y, 1F));
				
		}

		transform.position = new Vector3 (pos.x, pos.y, pos.z);
	}*/
}
