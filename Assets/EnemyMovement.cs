using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

	public GameObject enemy;

	Transform target;
	float speed = 1;

	// Use this for initialization
	void Start () {
		// Find player object
		target = GameObject.Find ("Player").transform;
		/*enemy = GameObject.Find ("Enemy");

		// Make enemies
		for (int i = 0; i < 5; i++) {
			Instantiate(enemy);

		}*/
	}
	
	// Update is called once per frame
	void Update () {
		// Move enemy towards player
		transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

	}
}
