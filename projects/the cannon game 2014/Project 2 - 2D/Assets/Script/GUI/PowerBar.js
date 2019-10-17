#pragma strict

function Start () {

}

function Update () {

if(transform.localScale.y <1){
if(Input.GetKey("up"))
	{
	transform.localScale += Vector3(0,0.01,0);
	}}

if(transform.localScale.y >0.01){
if(Input.GetKey("down"))
	{
	transform.localScale += Vector3(0,-0.01,0);
	}	}

}