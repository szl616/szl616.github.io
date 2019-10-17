using UnityEngine;
using System.Collections;

public class CarMovementScript : MonoBehaviour {
	public Transform centerOfMass;

	public static int AmountOfBoxes;

	public float maxTorque = 500f;
	public float steerForce;


	public float BrakeForce;
	public float SideWaysSlipRL;
	public float SideWaysSlipRR;

	/*public WheelCollider WheelColliderFR;
	public WheelCollider WheelColliderFL;
	public WheelCollider WheelColliderRR;
	public WheelCollider WheelColliderRL;*/

	public Transform[] tireMeshes = new Transform[4];
	public WheelCollider[] wheelColliders = new WheelCollider[4];
	public Vector3 tireMeshesOffset;



	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody> ().centerOfMass = centerOfMass.localPosition;
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (AmountOfBoxes);
		UpdateMeshesPosition ();

	}

	void FixedUpdate(){
		float h = Input.GetAxis ("Horizontal") * steerForce;
		float accelerate = Input.GetAxis ("Vertical");

		wheelColliders[0].steerAngle = h * steerForce;
		wheelColliders[1].steerAngle = h * steerForce;

		for(int i = 0; i<4; i++){
			wheelColliders[i].motorTorque = accelerate * maxTorque;

		}

		if(Input.GetKey(KeyCode.Space)){
			for(int i = 0; i<4;i++)
			{
				wheelColliders[i].brakeTorque = BrakeForce;
			}
		}else{
			for(int i = 0; i<4;i++)
			{
				wheelColliders[i].brakeTorque = 0;
			}
		}



	}


	/*void FixedUpdate()
	{
		float v = Input.GetAxis ("Vertical") * MotorForce;
		float h = Input.GetAxis ("Horizontal") * SteerForce;
		
		WheelColliderRL.motorTorque = v;
		WheelColliderRR.motorTorque = v;
		
		WheelColliderFR.steerAngle = h * SteerForce;
		WheelColliderFL.steerAngle = h * SteerForce;
		
		if(Input.GetKey(KeyCode.Space)){
			WheelColliderRL.brakeTorque = BrakeForce;
			WheelColliderRR.brakeTorque = BrakeForce;
			WheelColliderFL.brakeTorque = BrakeForce;
			WheelColliderFR.brakeTorque = BrakeForce;
		}else{
			WheelColliderRL.brakeTorque = 0;
			WheelColliderRR.brakeTorque = 0;
			WheelColliderFL.brakeTorque = 0;
			WheelColliderFR.brakeTorque = 0;
			
		}
		
		WheelHit hitRL;
		WheelHit hitRR;
		
		if(WheelColliderRL.GetGroundHit ( out hitRL))
		{
			SideWaysSlipRL = hitRL.sidewaysSlip;
		}
		if(WheelColliderRR.GetGroundHit ( out hitRR))
		{
			SideWaysSlipRR = hitRR.sidewaysSlip;
		}
	}*/

	void UpdateMeshesPosition ()
	{
		for (int i = 0; i < 4; i++) {
			Quaternion quat;
			Vector3 pos;
			wheelColliders[i].GetWorldPose(out pos, out quat);
			tireMeshes[i].position = pos+tireMeshesOffset;
			tireMeshes[i].rotation = quat;

		
		}

	}
}
