using UnityEngine;
using System.Collections;

public class EnemyManager : MonoBehaviour {

	public GameObject enemy;
	public float spawntime = 10f;
	public float startTime = 30f;
	public Transform[] spawnPoints;
	int numberOfEnemies = 1;
	
	void Start () {
		//This function calls the spawn method repeatedly every 3 seconds
		InvokeRepeating ("spawn", startTime, spawntime);
	}

	/**
	 * function spawn() creates an enemy at one of the spawn points
	 * */
	void spawn()
	{
		/* will stop the spawning function once player or base health reaches 0
		if (playerHealth.currHealth <= 0f || base.Health <=0f) {
			return;
		}*/
		int spawnPointIndex = Random.Range (0, spawnPoints.Length);
		Instantiate (enemy, spawnPoints [spawnPointIndex].position, spawnPoints [spawnPointIndex].rotation);
		numberOfEnemies++;

		if (numberOfEnemies > 20) {
			CancelInvoke ("spawn");
		}
		//Debug.Log ("Spawned enemy");
	}
	
	void Update () {
		
	}
}
