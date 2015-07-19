using UnityEngine;
using System.Collections;
			
public class ItemCollection : MonoBehaviour {

	private int batteryCount = 0;
	private int lightbulbCount = 0;	

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}

	//Increment battery count and remove battery from the game
	void OnTriggerEnter2D(Collider2D other) { 

		if (other.tag == "BatteryCollider") { 
			batteryCount += 1;
		} else if (other.tag == "LightbulbCollider") { 
			lightbulbCount += 1;
		}

	    Destroy(other.transform.parent.gameObject); //destroys the battery sprite
		Destroy(other.gameObject); //destroys the sprite's collider
		Debug.Log("Player touched Battery");
		Debug.Log (batteryCount);
	}

	void OnGUI(){
		GUI.Box (new Rect (0, 0, 100, 40), "Batteries: " + batteryCount);
		GUI.Box (new Rect (0, 50, 100, 40), "Lightbulbs: " + lightbulbCount);
	}
}