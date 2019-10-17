#pragma strict

function Start () {
renderer.enabled = false;
}

function Update () {

if(Victory.Won && Movement.Easy)
	{
	renderer.enabled = true;
	}else{
	renderer.enabled = false;
	}

}

