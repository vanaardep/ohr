using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

	Transform target;

	public float speed = 1;

	// Use this for initializations
	void Start () {
		// Find player object
		target = GameObject.Find ("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {
		// Move enemy towards player
		transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

	}
}
