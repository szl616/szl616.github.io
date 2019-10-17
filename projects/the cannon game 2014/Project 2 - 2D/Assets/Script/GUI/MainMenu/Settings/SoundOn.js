#pragma strict
static var SoundOn : boolean = true;


function Start () {

}

function Update () {

	if(SoundOn && Settings.Setting)
	{
	renderer.enabled = true;
	}
	if(!SoundOn && Settings.Setting)
	{
	renderer.enabled = false;
	}

}

function OnMouseUp () 
{
	SoundOn = false;
    
} 