static var GameOver : boolean = false;


function Start ()
{
renderer.enabled = false;
}


function Update ()
{
	if(GameOver && !Victory.Won)
	{
		renderer.enabled = true;
	}else{
	renderer.enabled = false;
	}
	
	
}