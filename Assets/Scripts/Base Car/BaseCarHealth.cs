﻿using UnityEngine;
using System.Collections;

public class BaseCarHealth : MonoBehaviour {

	private int baseCarHealth = 10;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// If base car collides with another collider minus its health if the collider is the Enemy class
	void OnCollisionEnter2D(Collision2D coll){
        if(coll.gameObject.name=="Enemy") {
        	if(baseCarHealth != 0){
    	        baseCarHealth -= 1;
        	}
        	else{
        		//Base car needs to die here
        	}
    	}
	}

	void OnGUI(){
		GUI.Box (new Rect (0, 150, 100, 40), "Base Health: " + baseCarHealth);
	}

}
