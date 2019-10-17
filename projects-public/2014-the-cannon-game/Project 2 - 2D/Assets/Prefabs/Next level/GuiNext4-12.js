

function OnMouseUp () 
{
	if(Victory.Won) 
	{
    Application.LoadLevel (12);
    Victory.Won = false;
    }
}    