#pragma strict
var Speed : int = 100;
var Backwards : boolean = false;

function Start () {

}

function Update () {

if(!Backwards){
transform.Rotate(Vector3.forward * Speed * Time.deltaTime);
}

if(Backwards){
transform.Rotate(Vector3.forward * Speed * -Time.deltaTime);
}
}


