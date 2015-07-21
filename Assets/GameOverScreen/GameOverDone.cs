using UnityEngine;
using System.Collections;

public class GameOverDone : MonoBehaviour {

	private float Timer = 0;

	// Use this for initialization
	void Start () {
		Timer = 0;
	}
	
	// Update is called once per frame
	void Update () {
		Timer += Time.deltaTime;
		if (Timer > 5)
		{
			Application.LoadLevel("level1");
		}
	}
}
