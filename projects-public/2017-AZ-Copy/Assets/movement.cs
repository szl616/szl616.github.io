using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {
    [Header("Tank Properties")]
    public float fwdSpeed;
    public float rotSpeed;

    [Header("Tank Gameobjects")]
    public GameObject bullet;
    public GameObject spawnPoint;
	public GameObject _killEffectPhys;

	private Rigidbody2D rb;

    [Header("Set if this is player 2")]
    public bool Player2;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if (!Player2)
        {
           	rb.AddRelativeForce (Input.GetAxis ("Vertical") * fwdSpeed * Time.deltaTime * Vector3.right);
			rb.AddTorque(Input.GetAxis("Horizontal") * -rotSpeed * Time.deltaTime);

            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(bullet, spawnPoint.transform.position, transform.rotation);
            }
        }
        else
        {
			rb.AddRelativeForce (Input.GetAxis ("Vertical1") * fwdSpeed * Time.deltaTime * Vector3.right);
			rb.AddTorque(Input.GetAxis("Horizontal1") * -rotSpeed * Time.deltaTime);

            if (Input.GetKeyDown(KeyCode.RightControl))
            {
                Instantiate(bullet, spawnPoint.transform.position, transform.rotation);
            }
        }

	}

	public void Kill(){
		GetComponent<Collider2D> ().enabled = false;
		transform.Find ("body").GetComponent<Renderer> ().enabled = false;
		transform.Find ("Barrel").GetComponent<Renderer> ().enabled = false;


		_killEffectPhys.SetActive (true);
		_killEffectPhys.transform.parent = null;
	}
}
