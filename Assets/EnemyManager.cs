using UnityEngine;
using System.Collections;

public class EnemyManager : MonoBehaviour {

	Transform enemy;

	// Use this for initialization
	void Start () {
		enemy = GameObject.Find("Enemy").transform;
		
		// Make enemies
		for (int i = 0; i < 5; i++) {
			Instantiate(enemy, new Vector3(i * 2.0F, 0, 0), Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
