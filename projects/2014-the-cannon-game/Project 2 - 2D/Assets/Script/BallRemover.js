#pragma strict

var ballCounter : int;

function Start () {
renderer.enabled = true;
}

function Update () {
	if(Movement.ballAmountVisual < ballCounter)
	{
	renderer.enabled = false;
	}


}