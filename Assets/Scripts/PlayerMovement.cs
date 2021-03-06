﻿using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	//public float speed;
	public Rigidbody2D rb;
	public AudioClip playermoveSound;
	//Public Vars
	//public Camera camera;
	public float speed;
	
	//Private Vars
	private Vector3 mousePosition;
	private Vector3 direction;
	private float distanceFromObject;
	private Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		rb = GetComponent<Rigidbody2D> ();
		//camera = Camera.main;

		speed = 0.09f;
	}
	
	// Update is called once per frame
	void Update () {

		anim.SetFloat ("playerSpeed", Mathf.Abs (Input.GetAxisRaw ("Horizontal")));
		anim.SetFloat ("playerSpeed", Mathf.Abs (Input.GetAxisRaw ("Vertical")));
		// Move player forward
		if(Input.GetAxisRaw("Vertical") > 0) {	
			transform.Translate(Vector2.up * speed);
		}
		if(Input.GetAxisRaw("Vertical") < 0) {
			transform.Translate(-Vector2.up * speed);
		}
		if(Input.GetAxisRaw("Horizontal") > 0) {
			transform.Translate(Vector2.right * speed);
		}
		if(Input.GetAxisRaw("Horizontal") < 0) {
			transform.Translate(-Vector2.right * speed);
		}

		// Check if light hits enemy
		/*Ray ray = new Ray (transform.position, transform.forward);
		RaycastHit hit;

		if (Physics.Raycast (ray, out hit, 100)) {
			Debug.Log (hit);
		}*/
	}

	void FixedUpdate() {
		//if (Input.GetButton("Fire2")){
			
			//Grab the current mouse position on the screen
		mousePosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,Input.mousePosition.y, Input.mousePosition.z - Camera.main.transform.position.z));
			
			//Rotates toward the mouse
			rb.transform.eulerAngles = new Vector3(0,0,Mathf.Atan2((mousePosition.y - transform.position.y), (mousePosition.x - transform.position.x))*Mathf.Rad2Deg - 90);
		
			//Judge the distance from the object and the mouse
			//distanceFromObject = (Input.mousePosition - camera.WorldToScreenPoint(transform.position)).magnitude;
			
			//Move towards the mouse
			//rigidbody.AddForce(direction * speed * distanceFromObject * Time.deltaTime);
			
		//}//End Move Towards If Case
		
	}//End Fire3 If case

	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.tag == "Enemy") {
			Debug.Log ("ENEMY HHIIIITTTT");
		} else if (coll.gameObject.tag == "baseCar") {
			Debug.Log ("CAR HHIIIITTTT");
		} else {
			Debug.Log ("BUILDING HHIIIITTTT");
		}
		
	}
}
