using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float speed;
	public Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.D)) {
			transform.Translate(Vector2.right * speed);
			//transform.position += Vector3.right * speed;
			//rb.AddForce(Vector2.right * speed);
			//rb.velocity = Vector2.right;
		}
		if(Input.GetKey(KeyCode.A)) {
			transform.Translate(-Vector2.right * speed);
		}
		if (Input.GetKey (KeyCode.W)) {
			transform.Translate (Vector2.up * speed);
		}
		if (Input.GetKey (KeyCode.S)) {
			transform.Translate (-Vector2.up * speed);
		}
	}

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
