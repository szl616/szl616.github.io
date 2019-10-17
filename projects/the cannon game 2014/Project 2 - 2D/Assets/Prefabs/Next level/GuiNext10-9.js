

function OnMouseUp () 
{
	if(Victory.Won) 
	{ 
 		Application.LoadLevel (9);
    	Victory.Won = false;
	}
}