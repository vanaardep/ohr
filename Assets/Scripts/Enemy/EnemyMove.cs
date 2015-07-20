using UnityEngine;
using System.Collections;

public class EnemyMove : MonoBehaviour {
	
	Transform player;
	Transform baseCar;
	
	float speed = 1f;
	float angleSpread = 20;
	float enemyFreezeTime = 4;

	// Distances and light	
	bool inLight = false;
	float distanceToPlayer;
	float distanceToCar;
	Vector3 playerZRotation;
	Vector3 enemyPosition;
	Vector3 facing;
	
	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player").transform;
		baseCar = GameObject.Find ("baseCar").transform;

		InvokeRepeating ("checkDistances", 0, 1.0f);
	}
	
	// Update is called once per frame
	void Update () {

		if (!inLight) {
			// Check if enemy in angle
			//========================
			if (distanceToPlayer <= 25 && ((facing.z - angleSpread) < playerZRotation.z && playerZRotation.z < (facing.z + angleSpread))) {
				inLight = true;
				Debug.Log ("FREEEEZE BITCH");
				Invoke("unfreezeEnemy", enemyFreezeTime);
			} 
			
			if (distanceToPlayer < distanceToCar) {
				// Move towards player
				transform.position = Vector3.MoveTowards (transform.position, player.position, speed * Time.deltaTime);
			} else {
				// Move towards car
				transform.position = Vector3.MoveTowards (transform.position, baseCar.position, speed * Time.deltaTime);
			}
		}
	}

	void checkDistances(){
		// Distance from player
		distanceToPlayer = (this.transform.position - player.position).sqrMagnitude;//Vector2.Distance (this.transform.position, player.transform.position);
		distanceToCar = (this.transform.position - baseCar.position).sqrMagnitude;//Vector2.Distance (this.transform.position, baseCar.transform.position);
		
		// Player z
		playerZRotation = player.rotation.eulerAngles;
		
		// Angle to player
		//================
		//Vector3 directionToTarget = player.position - this.transform.position;
		//float angle = Vector3.Angle (player.forward, directionToTarget);
		
		//Vector3 targetDir = player.position - this.transform.position;
		//Vector3 forward = this.transform.forward;
		//float angle = Vector3.Angle(targetDir, forward);
		
		/*Vector2 heading = this.transform.position - player.position;
		float distance2 = heading.magnitude;
		Vector2 angle = heading / distance2; // This is now the normalized direction.*/
		
		//float angle = SignedAngleBetween(this.transform.position, player.position, player.position);
		
		//Grab the current mouse position on the screen
		enemyPosition = this.transform.position;//camera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,Input.mousePosition.y, Input.mousePosition.z - camera.transform.position.z));
		
		//Rotates toward the mouse
		facing = new Vector3(0,0,Mathf.Atan2((enemyPosition.y - player.position.y), (enemyPosition.x - player.position.x))*Mathf.Rad2Deg + 90);
		
		//Debug.Log (facing.z + " VS " + playerZRotation.z);
	}
	
	void unfreezeEnemy () {
		inLight = false;
	}
}
