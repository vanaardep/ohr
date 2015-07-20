using UnityEngine;
using System.Collections;

public class LightManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log ("err");
	}

	//void OnTriggerExit(Collider other)
	//{
	//	Debug.Log ("Exit hsdh");
	//}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player") 
		{
			Debug.Log("Player entered");
		}
	}

	void OnTriggerExit2D(Collider2D other)
	{
		Debug.Log ("hey");
		if (other.tag == "Player") 
		{
			Debug.Log("Player exit");
		}
	}

	/*void OnTriggerExit(Collider other)
	{
		Debug.Log ("why");
	}*/
}
