
		
function OnMouseUp () 
{
	if(Victory.Won) 
	{
    Application.LoadLevel (8);
    Victory.Won = false;
    }
}    