using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

	public GameObject enemy;
	public float spawntime = 3f;
	public Transform[] spawnPoints;

	//Transform target;
	//float speed = 1f;

	// Use this for initialization
	void Start () {

		InvokeRepeating ("spawn", spawntime, spawntime);
		// Find player object
		//target = GameObject.Find ("Player").transform;
		//enemy = GameObject.Find("Enemy");
		/*enemy = GameObject.FindWithTag ("Enemy");
		enemy = GameObject.Instantiate;

		// Make enemies
		for (int i = 0; i < 5; i++) {
			Debug.Log("Dirkie has small penis");
			Instantiate(enemy);

		}*/
	}

	void spawn()
	{
		int spawnPointIndex = Random.Range (0, spawnPoints.Length);
		Instantiate (enemy, spawnPoints [spawnPointIndex].position, spawnPoints [spawnPointIndex].rotation);
	}
	
	// Update is called once per frame
	void Update () {
		// Move enemy towards player
		//transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

	}
}
