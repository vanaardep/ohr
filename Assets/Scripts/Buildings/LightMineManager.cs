using UnityEngine;
using System.Collections;

public class LightMineManager : MonoBehaviour {

	// Use this for initialization
	private bool timeToExplode = false;
	private int count = 0;
	void Start () {
	
	}
	void OnTriggerEnter2D(Collider2D other){

		if (other.name == "enemyCollider") { //If collide with enemy set explosion variable to true
			//Debug.Log ("Leeeeeeeeeeeeroooooyy Jenkkkkiinsss");
			timeToExplode = true;
			count++;
		}
	}

	void OnTriggerStay2D(Collider2D other){
			
		if (timeToExplode == true && other.name == "enemyCollider") { //If explosion trigger == true, 
																	  //destroy all enemies in collider range
			//Debug.Log(other.transform.parent.gameObject);
			Destroy(other.transform.parent.gameObject);
			Destroy(gameObject);
			ItemCollection.lightMineCount--;
		}


	}
	void OnTriggerExit2D(Collider2D other){

	}

	// Update is called once per frame
	void Update () {
	
	}
}
