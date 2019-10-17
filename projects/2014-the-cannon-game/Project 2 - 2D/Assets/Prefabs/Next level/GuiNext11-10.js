

function OnMouseUp () 
{
	if(Victory.Won) 
	{ 
		
	    Application.LoadLevel (10);
	    Victory.Won = false;
    }
}