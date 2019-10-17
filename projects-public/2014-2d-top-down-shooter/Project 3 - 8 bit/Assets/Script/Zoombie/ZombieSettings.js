 var Player : Transform;
 var MoveSpeed = 4;
 var MaxDist = 10;
 var MinDist = 5;
 
 
 
 
 function Start () 
 {
 
 
 }
 
 function Update () 
 {
 	transform.position.z = 0;
 	transform.rotation.x = 0;
 	if(transform.position.z == 0 && transform.rotation.x == 0)
 	{
 	transform.rotation.y = 0;
     transform.LookAt(Player);
     
     if(Vector2.Distance(transform.position,Player.position) >= MinDist){
     
          transform.position += transform.forward*MoveSpeed*Time.deltaTime;
 
           
           
          if(Vector3.Distance(transform.position,Player.position) <= MaxDist)
              {
                 //Here Call any function U want Like Shoot at here or something
    } 
    
    }
    }
 }