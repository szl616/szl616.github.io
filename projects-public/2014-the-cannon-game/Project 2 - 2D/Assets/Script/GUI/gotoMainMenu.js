function OnMouseUp () 
{
	if(Victory.Won || GameOver.GameOver) 
	{ 
		
	    Application.LoadLevel (0);
	    Victory.Won = false;
    }
    
   
}

function Update ()
{

 if(GameOver.GameOver)
    {
    renderer.enabled = true;
    
    }

}