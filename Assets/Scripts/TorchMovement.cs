using UnityEngine;
using System.Collections;

public class TorchMovement : MonoBehaviour {

	Transform target;

	// Use this for initialization
	void Start () {
		target = GameObject.Find ("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {
		//0.9 torch dist -0.001f torch height
		transform.position = target.position + new Vector3 (0, 0.8f, -0.001f);
	}
}
