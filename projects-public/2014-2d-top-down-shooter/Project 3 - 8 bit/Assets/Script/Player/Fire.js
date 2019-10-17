#pragma strict
var Player:GameObject;
var PlayerSpeed : float = 1.0;
var bulletPower : int = 1000;
var bulletPrefab:Transform;
var Cooldown : boolean = false;

var fireSet : int = 2; // 1 = Right, 2 = Up, 3 = Left, 4 = down

function Start () {

}

function Update () 
{
	//Styrring
	if(Move_Up.Move)
	{
			fireSet = 2;
			Player.transform.Translate(Vector3.down * Time.deltaTime * PlayerSpeed);
			transform.eulerAngles.z = 180;
	}
	
	if(Move_Left.Move)
	{
			fireSet = 3;
			Player.transform.Translate(Vector3.down * Time.deltaTime * PlayerSpeed);
			transform.eulerAngles.z = 270;
			
	}
	
	if(Move_Right.Move)
	{
			fireSet = 1;
			Player.transform.Translate(Vector3.down * Time.deltaTime * PlayerSpeed);
			transform.eulerAngles.z = 90;
			
	}
	
	if(Move_Down.Move)
	{
			fireSet = 4;
			Player.transform.Translate(Vector3.down * Time.deltaTime * PlayerSpeed);
			transform.eulerAngles.z = 0;
			
	}
}

function OnMouseDown()
{

if(!Cooldown){
Cooldown = true;
var bullit = Instantiate(bulletPrefab, 
						GameObject.Find("PistolSpawn").transform.position,
						GameObject.Find("Player").transform.rotation);
		switch(fireSet)
		{
		case 1:
		bullit.rigidbody2D.AddForce(Vector2.right * bulletPower);
		break;
		
		case 2:
		bullit.rigidbody2D.AddForce(Vector2.up * bulletPower);
		break;
		
		case 3:
		bullit.rigidbody2D.AddForce(Vector2.right * -bulletPower);
		break;
		
		case 4:
		bullit.rigidbody2D.AddForce(Vector2.up * -bulletPower);
		break;
		
		}
}


}

function OnMouseUp()
{
Cooldown = false;



}