using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerBuildTurrets : MonoBehaviour {

	// Use this for initialization

	public Transform newTurret1;
	public Transform newTurret2;
	public AudioClip buildSound;

	//Variables for onscreen Message
	private string msg;
	private float displayTime = 3f;
	private bool display = false;

	void Start () {

	}

	void Update()
	{
		displayTime -= Time.deltaTime;
		if (displayTime <= 0.0) {
			display = false;
		}
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		//Data structures to keep track of active towers
		List <GameObject> activeTower1 = new List <GameObject> (); 
		List <GameObject> activeTower2 = new List <GameObject> ();

		Vector3 playerPosition = GameObject.Find("Player").transform.position;


		if(Input.GetKeyUp(KeyCode.Space)) { //Deploy turret type 1
			//Debug.Log("Pressed space");
			if(ItemCollection.batteryCount >0)
			{
				GameObject thisObject = Instantiate(newTurret1, playerPosition, Quaternion.identity) as GameObject; //add tower to list
				activeTower1.Add(thisObject);
				SoundManager.instance.PlaySingle(buildSound);
				ItemCollection.batteryCount--;
			}
			else
			{
				msg = "Need Batteries";
				//Debug.Log ("Need batteries");
				displayTime = 3f;
				display = true;

			}
		}

		if(Input.GetKeyUp(KeyCode.E)) { //Deploy turret type 2
			//Debug.Log("Pressed E");
			if(ItemCollection.lightbulbCount >0)
			{
				GameObject thisObject = Instantiate(newTurret2, playerPosition, Quaternion.identity) as GameObject; //add tower to list
				activeTower2.Add(thisObject);
				SoundManager.instance.PlaySingle(buildSound);
				ItemCollection.lightbulbCount--;
			}
			else
			{
				//Debug.Log ("Need Lightbulbs");
				msg = "Need Lightbulbs";
				displayTime = 3f;
				display = true;

			}
		}

	}

	void OnGUI () {
		if (display) {
			GUI.Label (new Rect ((Screen.width / 2)-30, (Screen.height/2) - 140, 200f, 200f), msg);
		}
	}


}
