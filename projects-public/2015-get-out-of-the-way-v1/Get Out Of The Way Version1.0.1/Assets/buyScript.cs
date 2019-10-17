using UnityEngine;
using System.Collections;

public class buyScript : MonoBehaviour {
	private Renderer rend;
	private Collider2D coll;
	public int Car1Price;
	public int Car2Price;
	public int Car3Price;
	public int Car4Price;
	public int Car5Price;

	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer> ();
		coll = GetComponent<Collider2D>();

	}
	
	// Update is called once per frame
	void Update () {

		switch (moveByTouch.ChoosenObject) {
		case 1: if(PlayerPrefs.GetInt ("Car1")==1)
			{
				youHaveThis.show = true;
				youCantAfford.show = false;
				rend.enabled = false;
				coll.enabled = false;

			}else{
				youHaveThis.show = false;
				if(PlayerPrefs.GetInt("Money") >= Car1Price)
				{
					youCantAfford.show = false;
					rend.enabled = true;
					coll.enabled = true;
				}else{
					youCantAfford.show = true;
					rend.enabled = false;
					coll.enabled = false;
				}
			}
			break;
		case 2: if(PlayerPrefs.GetInt ("Car2")==1)
			{
				youHaveThis.show = true;
				youCantAfford.show = false;
				rend.enabled = false;
				coll.enabled = false;
			}else{
				youHaveThis.show = false;
				if(PlayerPrefs.GetInt("Money") >= Car2Price)
				{
					youCantAfford.show = false;
					youCantAfford.show = false;
					rend.enabled = true;
					coll.enabled = true;
				}else{
					youCantAfford.show = true;
					rend.enabled = false;
					coll.enabled = false;
				}
			}
			break;
		case 3: if(PlayerPrefs.GetInt ("Car3")==1)
			{
				youHaveThis.show = true;
				youCantAfford.show = false;
				rend.enabled = false;
				coll.enabled = false;
			}else{
				youHaveThis.show = false;
				if(PlayerPrefs.GetInt("Money") >= Car3Price)
				{
					youCantAfford.show = false;
					rend.enabled = true;
					coll.enabled = true;
				}else{
					youCantAfford.show = true;
					rend.enabled = false;
					coll.enabled = false;
				}
			}
			break;
		case 4: if(PlayerPrefs.GetInt ("Car4")==1)
			{
				youHaveThis.show = true;
				youCantAfford.show = false;
				rend.enabled = false;
				coll.enabled = false;
			}else{
				youHaveThis.show = false;
				if(PlayerPrefs.GetInt("Money") >= Car4Price)
				{
					youCantAfford.show = false;
					rend.enabled = true;
					coll.enabled = true;
				}else{
					youCantAfford.show = true;
					rend.enabled = false;
					coll.enabled = false;
				}
			}
			break;
		case 5: if(PlayerPrefs.GetInt ("Car5")==1)
			{
				youHaveThis.show = true;
				youCantAfford.show = false;
				rend.enabled = false;
				coll.enabled = false;
			}else{
				youHaveThis.show = false;
				if(PlayerPrefs.GetInt("Money") >= Car5Price)
				{
					youCantAfford.show = false;
					rend.enabled = true;
					coll.enabled = true;
				}else{
					youCantAfford.show = true;
					rend.enabled = false;
					coll.enabled = false;
				}
			}
			break;
			
		}
	
	}
}
