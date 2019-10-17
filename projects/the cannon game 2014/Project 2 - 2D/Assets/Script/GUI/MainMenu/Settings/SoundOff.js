function Update () {

	if(!SoundOn.SoundOn && Settings.Setting)
	{
	renderer.enabled = true;
	}
	
	if(SoundOn.SoundOn && Settings.Setting)
	{
	renderer.enabled = false;
	}

}

function OnMouseUp () 
{
	SoundOn.SoundOn = true;
    
} 