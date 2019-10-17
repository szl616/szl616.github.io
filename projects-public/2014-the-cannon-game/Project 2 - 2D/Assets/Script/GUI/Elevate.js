


var Slut : float = 0;
var Speed : float = 0;
var Return : boolean = false;


function Start () {

}

function Update () {



}

function Elevate ()
	{
	 if(transform.position.y < Slut && !Return)
	 	{
		transform.position.y -= Speed * Time.deltaTime;
		if(transform.position.y >= Slut)
			{
				Return = true;
			}
		} else {
		transform.position.y -= Speed * -Time.deltaTime;
			
		}
		
		}