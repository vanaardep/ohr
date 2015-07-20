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
		//rb.collisionDetectionMode.Equals = true;
		//rb.collider.enabled = true;

	}

	void OnCollisionEnter2D(Collision2D coll)
	{
		//gameObject.GetComponent<BoxCollider2D>().enabled = true;
		if (coll.gameObject.tag == "Enemy") {
			//gameObject.GetComponent<BoxCollider2D>().enabled = true;
			Debug.Log ("ENEMY HHIIIITTTT");
		} else if (coll.gameObject.tag == "baseCar") {
			Debug.Log ("CAR HHIIIITTTT");
		} 
		else if (coll.gameObject.tag == "Ward") 
		{
			Debug.Log("Ward");
			//gameObject.collider.active = false;
			//rb.collisionDetectionMode.Equals(false);
			//coll.collider.enabled = false;
			//gameObject.GetComponent<BoxCollider2D>().enabled = false;
		
			//gameObject.GetComponent<BoxCollider2D>().enabled = true;
		}
		else {
			Debug.Log ("BUILDING HHIIIITTTT");
		}
		
	}
	/*void onCollisionExit2D(Collision2D coll)
	{
		gameObject.GetComponent<BoxCollider2D>().enabled = false;
	}*/
}
