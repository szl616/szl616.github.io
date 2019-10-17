

function OnMouseUp () 
{
	if(Victory.Won) 
	{
	
    Application.LoadLevel (13);
    Victory.Won = false;
    }
}    