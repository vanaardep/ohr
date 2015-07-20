using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

	Transform target;

	//float minFov  = 15;
	//float maxFov  = 90;
	//float sensitivity  = 10;

	// Use this for initialization
	void Start () {
		target = GameObject.Find ("Player").transform;

		// Set camera zoom
		Camera.main.orthographic = true;
		Camera.main.orthographicSize = 3f;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = target.position + new Vector3 (0, 0, -2);
	}
}
