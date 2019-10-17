#pragma strict
static var StartGame : boolean = false;

function Start()
{
	StartGame = false;
	Movement.Easy = false;
	Movement.Medium = false;
	Movement.HC = false;
}

function Update()
{
	if(StartGame || Settings.Setting)
	{
	renderer.enabled = false;
	}else{
	renderer.enabled = true;
	}
	
	if(Input.GetTouch(0).phase)
	{
	StartGame = true;
	
	}
	
}


function OnMouseUp () 
{
	if(!StartGame)
	{
    StartGame = true;
    }
    
}    