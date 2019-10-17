function Update ()
{
	if(StartGame.StartGame)
	{
	renderer.enabled = true;
	}else{
	renderer.enabled = false;
	}

}


function OnMouseUp () 
{
	if(StartGame.StartGame){
    Movement.Easy = true;
	
    Application.LoadLevel (1);
    }
}    