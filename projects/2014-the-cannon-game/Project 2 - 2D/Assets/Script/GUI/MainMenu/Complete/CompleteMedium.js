#pragma strict

function Start () {
renderer.enabled = false;
}

function Update () {

if(Victory.Won && Movement.Medium)
	{
	renderer.enabled = true;
	}else{
	renderer.enabled = false;
	}

}

