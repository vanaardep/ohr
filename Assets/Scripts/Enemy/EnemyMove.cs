using UnityEngine;
using System.Collections;

public class EnemyMove : MonoBehaviour {

	Transform player;

	float speed = 1f;
	float angleSpread = 20;
	float enemyFreezeTime = 2;

	bool inLight = false;

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {

		// Distance from player
		float distance = Vector2.Distance (this.transform.position, player.transform.position);
		// Player z
		float playerZRotation = player.transform.localEulerAngles.z;

		// Angle to player

		float angle = Vector3.Angle (player.position, this.transform.position);
		//float angle = findAngle();

		/*Vector2 heading = this.transform.position - player.position;
		float distance2 = heading.magnitude;
		Vector2 angle = heading / distance2; // This is now the normalized direction.

		Debug.Log (angle + " VS " + playerZRotation);*/

		// Check if enemy in angle
		if (distance <= 3 ) {//&& ((angle - angleSpread) < playerZRotation && playerZRotation < (angle + angleSpread))) {
			inLight = true;
		} else {
			Invoke("unfreezeEnemy", 2);
		}
		

		// Move towards player
		if (!inLight) {
			transform.position = Vector3.MoveTowards (transform.position, player.position, speed * Time.deltaTime);
		}
	}

	void unfreezeEnemy () {
		inLight = false;
	}

	float findAngle()
	{
		var angle = Mathf.Atan2(this.transform.position.y - player.position.y, this.transform.position.x - player.position.x) * 180 / Mathf.PI;
		return angle;
	}
}
