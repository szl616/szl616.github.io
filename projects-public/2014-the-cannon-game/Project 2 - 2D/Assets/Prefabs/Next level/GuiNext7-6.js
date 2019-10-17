

function OnMouseUp () 
{
	if(Victory.Won) 
	{
    Application.LoadLevel (6);
    Victory.Won = false;
    }
}