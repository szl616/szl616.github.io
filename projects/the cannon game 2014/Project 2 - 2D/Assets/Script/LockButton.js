#pragma strict
var Target:Transform;


function Start () {

}

function Update () {

}

function OnCollisionEnter2D( Collision2D )
	{
		
				Target.gameObject.SendMessage ("Destroy", true);
				Destroy (gameObject);
		
	
	}
