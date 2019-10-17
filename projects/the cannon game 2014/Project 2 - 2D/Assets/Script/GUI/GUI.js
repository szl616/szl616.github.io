#pragma strict

function Start () {
renderer.enabled = false;
}

function Update () {

if(Victory.Won && !GameOver.GameOver)
	{
	renderer.enabled = true;
	}else{
	renderer.enabled = false;
	}

}

