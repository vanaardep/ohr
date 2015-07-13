using UnityEngine;
using System.Collections;

public class EnemyMove : MonoBehaviour {

	Transform target;
	float speed = 1f;

	// Use this for initialization
	void Start () {
		target = GameObject.Find ("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

	}
}
