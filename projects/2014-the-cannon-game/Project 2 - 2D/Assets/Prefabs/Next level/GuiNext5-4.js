

function OnMouseUp () 
{
	if(Victory.Won) 
	{
    Application.LoadLevel (4);
    Victory.Won = false;
    }
}    