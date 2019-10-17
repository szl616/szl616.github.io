function Update()
{
	if(StartGame.StartGame || Settings.Setting)
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
		
	    Application.Quit();
	    Debug.Log("App Lukket");
    }
}