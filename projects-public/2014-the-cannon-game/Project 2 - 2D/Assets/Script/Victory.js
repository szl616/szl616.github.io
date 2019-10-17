

#pragma strict
static var Won : boolean = false;
function Start () {
}
 
function OnCollisionEnter2D(test : Collision2D) {
    Debug.Log("Collided"); // Inform if something had collided with object
    if(test.gameObject.tag == "Ball")
    {
    	Won = true;
        Movement.CannonPower = 1000;
    	Debug.Log("!!!!!Winner!!!!!"); // Inform if the "Right" object had collided
    }
}