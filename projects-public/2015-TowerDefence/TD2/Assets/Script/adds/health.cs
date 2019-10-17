using UnityEngine;
using System.Collections;

public class health : MonoBehaviour {
	public double Health = 100;

	// Armor Type
	public bool ArmorNo = false;
	public bool ArmorMagic = false;
	public bool ArmorStone = false;
	public bool ArmorFire = false;
	public bool ArmorWater = false;
	public bool ArmorElectric = false;

	private double damage;
	private string damageType;

	private bool applyDamage = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Health <= 0) 
		{
			Destroy(gameObject);
		}
		


		if (applyDamage) {
			if(ArmorNo)
			{
				Health -= damage;

			}

			if(ArmorMagic)
			{
				if(damageType == "normal")
				{
					Health -= damage* 1.5;
				}else{
					Health -= damage* 0.7;
				}

			}


			if(ArmorStone)
			{
				if(damageType == "fire" || damageType == "laser")
				{
					Health -= damage*1.2;
				}else{
					if(damageType == "normal")
					{
						Health -= damage*0.5;
					}else{
						Health -= damage*0.7;
					}
				}
			}

			if(ArmorFire)
			{
					if(damageType == "fire" || damageType == "laser")
					{
						Health -= damage*0;
					}else{
						if(damageType == "water")
						{
							Health -= damage*1.5;
						}else{
						if(damageType == "posion")
						{
							Health -= damage*1.2;
						}else{
							Health -= damage*0.7;
						}
					}
				}				
			}

			if(ArmorWater)
			{
				if(damageType == "electric")
				{
					Health -= damage*1.5;
				}else{
					Health -= damage*0;
				}

			}

			if(ArmorElectric)
			{
				if(damageType == "water")
				{
					Health -= damage*1.5;
				}else{
					if(damageType == "electric")
					{
						Health -= damage*0;
					}else{
						if(damageType == "posion")
						{
							Health -= damage*0.7;
						}else{
							Health -= damage;
						}
					}
				}
			}


			applyDamage = false;
		}



	}
	
	void TakeDamage (float towerDamage)
	{
		damage = towerDamage;
		applyDamage = true;
	}

	void TakeDamageType (string towerDamageType)
	{
		damageType = towerDamageType;
		applyDamage = true;
	}
}
