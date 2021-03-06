﻿using UnityEngine;
using System.Collections;

public class SignalLightManager : MonoBehaviour {

	public Light lt;
	public float signalLightLifeTime;
	// Use this for initialization
	void Start () {
		//lt = GetComponent<Light> ();
		Destroy (gameObject, signalLightLifeTime);
	}

	void OnTriggerEnter2D(Collider2D other){
		Debug.Log ("entered radius");
		Debug.Log (other.gameObject.tag);
		Debug.Log (other);
		if (other.name == "enemyCollider") { //If enemy enter collision radius turn red + increase intensity
			lt.color = Color.red;
			lt.intensity++;
		}
	

	}
	void OnTriggerStay2D(Collider2D other){
	//	Debug.Log ("stayyyying");
		if (other.name == "enemyCollider") { //As long as enemy within radius stay red
			lt.color = Color.red;
		}
	}
	void OnTriggerExit2D(Collider2D other){
		if (other.name == "enemyCollider") { //When enemy leave, and none are left in radius turn back to green
			lt.intensity--;
			lt.color = Color.green;
		}
	}
	// Update is called once per frame
	void Update () {
	
	}
}
