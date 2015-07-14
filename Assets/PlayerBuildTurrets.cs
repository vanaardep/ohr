using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerBuildTurrets : MonoBehaviour {

	// Use this for initialization

	Transform newTurret1;
	Transform newTurret2;

	void Start () {

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		//Data structures to keep track of active towers
		List <GameObject> activeTower1 = new List <GameObject> (); 
		List <GameObject> activeTower2 = new List <GameObject> ();

		//Declaring turrets
		newTurret1 = GameObject.Find ("turret1").transform;
		newTurret2 = GameObject.Find ("turret2").transform;

		Vector3 playerPosition = GameObject.Find("Player").transform.position; //Get Player's position


		if(Input.GetKeyUp(KeyCode.Space)) { //Deploy turret type 1
			Debug.Log("Pressed space");
			GameObject thisObject = Instantiate(newTurret1, playerPosition, Quaternion.identity) as GameObject; //add tower to list
			activeTower1.Add(thisObject);
		}

		if(Input.GetKeyUp(KeyCode.E)) { //Deploy turret type 2
			Debug.Log("Pressed space");
			GameObject thisObject = Instantiate(newTurret2, playerPosition, Quaternion.identity) as GameObject; //add tower to list
			activeTower1.Add(thisObject);
		}

	}


}
