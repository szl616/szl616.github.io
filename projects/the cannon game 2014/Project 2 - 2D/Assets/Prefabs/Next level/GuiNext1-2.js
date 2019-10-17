

function OnMouseUp () 
{
	if(Victory.Won) 
	{
    Application.LoadLevel (2);
    Victory.Won = false;
    }
    
}