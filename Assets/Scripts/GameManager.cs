using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (PlayerHealth.playerHealth <= 0 || BaseCarHealth.baseCarHealth <= 0) 
		{
			Debug.Log ("Inside end");
			Application.LoadLevel("GameOver");

		}
	
	}
}
