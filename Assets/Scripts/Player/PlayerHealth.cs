using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour {

	private int playerHealth = 10;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D coll){
        if(coll.gameObject.tag=="Enemy") {
        	if(playerHealth != 0){
    	        playerHealth -= 1;
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
