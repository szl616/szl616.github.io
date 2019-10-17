

function OnMouseUp () 
{
	if(Victory.Won) 
	{
    Application.LoadLevel (7);
    Victory.Won = false;
    }
}    