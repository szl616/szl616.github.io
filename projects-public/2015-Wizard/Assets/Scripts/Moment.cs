using UnityEngine;
using System.Collections;

public class Moment : MonoBehaviour {
	public float speed = 1.0F;
	public float offset = 1.0F;
	Animator anim;
	public Transform spawnPoint;
	public Transform FireballPrefab;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {

		//float distance = Vector3.Distance (transform.position, Input.mousePosition); 
		float move = Input.GetAxis ("Vertical");
		//anim.SetFloat ("Speed", move);


		transform.Translate (0, Input.GetAxis ("Vertical") * speed * Time.deltaTime, 0);
		
		transform.Translate(Input.GetAxis("Horizontal")*speed * Time.deltaTime, 0, 0);

		Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
		Vector3 lookPos = Camera.main.ScreenToWorldPoint(mousePos);
		lookPos = lookPos - transform.position;
		float angle = Mathf.Atan2(lookPos.y, lookPos.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.AngleAxis(angle-90F, Vector3.forward);

		if (Input.GetButtonDown ("Fire1")) {
			Transform bullit = (Transform)Instantiate(FireballPrefab, spawnPoint.transform.position, transform.rotation);


		}


	}
}
