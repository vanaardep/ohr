using UnityEngine;
using System.Collections;

public class BatteryCollection : MonoBehaviour {

	public int score = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


		//OnTriggerEnter (this);

	
	}

	//Increment battery count and remove battery from the game
	void OnTriggerEnter2D(Collider2D other) { 
		//if (other.tag == "BatteryCollider") { 
			score += 1; 
		    Destroy(other.transform.parent.gameObject);
			Destroy(other.gameObject);
			Debug.Log("Player touched Battery");

		//} 
	}
}
