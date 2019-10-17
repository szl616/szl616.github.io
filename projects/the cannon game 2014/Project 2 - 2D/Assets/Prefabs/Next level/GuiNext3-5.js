
		
function OnMouseUp () 
{
	if(Victory.Won) 
	{
    Application.LoadLevel (5);
    Victory.Won = false;
    }
}    