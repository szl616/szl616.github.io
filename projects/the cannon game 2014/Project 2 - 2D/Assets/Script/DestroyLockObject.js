#pragma strict

function Start () {

}

function Update () {

}

function Destroy ( destroy : boolean)
{
	if(destroy)
	{
	Destroy (gameObject);
	}

}