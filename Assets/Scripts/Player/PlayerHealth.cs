﻿using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour {

	public static int playerHealth = 10;
	public AudioClip hurtSound;

	// Use this for initialization
	void Start () {
		playerHealth = 10;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D coll){
        if(coll.gameObject.tag=="Enemy") {
        	if(playerHealth != 0){
    	        playerHealth -= 1;
    	        SoundManager.instance.PlaySingle(hurtSound); //player getting hurt
        	}
        	else{
        		//GameObject.Destroy("Player");
        	}
    	}
	}

	void OnGUI(){
		GUI.Box (new Rect (0, 100, 100, 40), "Health: " + playerHealth);
	}

}
