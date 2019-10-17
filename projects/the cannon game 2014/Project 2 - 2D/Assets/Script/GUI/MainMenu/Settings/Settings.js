static var Setting : boolean = false;

function Start ()
{
Setting = false;

}

function Update()
{
	if(StartGame.StartGame || Setting)
	{
	renderer.enabled = false;
	}else{
	renderer.enabled = true;
	}
	
	
	
}

function OnMouseUp () 
{
	if(!StartGame.StartGame) 
	{ 
		Debug.Log("Settings");
		Setting = true;
	    
    }
}