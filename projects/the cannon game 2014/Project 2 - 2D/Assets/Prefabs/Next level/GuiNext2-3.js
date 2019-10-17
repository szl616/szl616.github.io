

function OnMouseUp () 
{
	if(Victory.Won) 
	{
    Application.LoadLevel (3);
    Victory.Won = false;
    }
}