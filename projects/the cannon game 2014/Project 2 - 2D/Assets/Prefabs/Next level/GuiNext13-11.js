

function OnMouseUp () 
{
	if(Victory.Won) 
	{
    Application.LoadLevel (11);
    Victory.Won = false;
    }
}    