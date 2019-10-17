#pragma strict
var RotateSpeed : int;
static var CannonPower : int = 1000;
var CannonPrefab:Transform;
var k : float = 32;
var CD : boolean = false;
var CDtimer : int = 2;
static var ballAmount : int = 10;
static var ballAmountVisual : int = 10;
static var Easy : boolean;
static var Medium : boolean;
static var HC : boolean;

var CannonSound : AudioClip;
var CannonVolume : float = 1.0;
@script RequireComponent(AudioSource)

function Start () {
		CannonPower = 1000;
		ballAmount = 10;
		ballAmountVisual = 10;
		GameOver.GameOver = false;

if(Easy)
	{
		ballAmount = 10;
		ballAmountVisual = 10;
	}
	
if(Medium)
	{
		ballAmount = 5;
		ballAmountVisual = 5;
	}
	
if(HC)
	{
		ballAmount = 1;
		ballAmountVisual = 1;
	}

	}

function Fire ()
	{
	if(!CD && ballAmount <= 0)
	{
	GameOver.GameOver = true;
	}
	
	if(!CD && ballAmount > 0){
	var bullit = Instantiate(CannonPrefab, GameObject.Find("spawnPoint").transform.position ,transform.rotation);
		bullit.rigidbody2D.AddForce(transform.right * CannonPower);
		CD = true;
		ballAmountVisual--;
		audio.Play();
		yield WaitForSeconds(CDtimer);
		CD = false;
		ballAmount--;
		
	}
	}

function Update () {

	


if(Input.GetButtonDown("Jump") && !Victory.Won)
	{
		Fire();
	}




if(CannonPower <200)
	{
	CannonPower = 200;
	}
	
if(CannonPower >1000)
	{
	CannonPower = 1000;
	}














		if(Input.GetKey("down"))
			{
			 CannonPower = CannonPower - 10;
			 Debug.Log(CannonPower);
			}
			
		if(Input.GetKey("up"))
			{
			 CannonPower = CannonPower + 10;
			 Debug.Log(CannonPower);
			}



		if(Input.GetKey("left"))
			{
			transform.Rotate (Vector3.forward * Time.deltaTime* RotateSpeed);
			k++;
			}

	

		if(Input.GetKey("right"))
			{
			transform.Rotate (Vector3.forward * Time.deltaTime* -RotateSpeed);
			k--;
			}
}