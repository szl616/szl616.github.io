function OnControllerColliderHit(hit : ControllerColliderHit)
{
	if(hit.gameObject.tag == "wall")
	{
		Debug.Log("Ramt");
		Destroy (gameObject);
	}
}