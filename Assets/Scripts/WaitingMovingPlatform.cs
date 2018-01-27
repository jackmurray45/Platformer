using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitingMovingPlatform : MonoBehaviour {

	public Vector3 position1;
	public Vector3 position2;
	public Vector3 newPosition;
	public string currentState;
	public float timeToMove = 10.0f;
	public int resetTime = 3;
	public bool isTriggered = false;
	public GameObject player;



	// Use this for initialization
	void Start () {

		position1 = new Vector3 (transform.position.x, transform.position.y, transform.position.z);
		position2 = new Vector3 (position1.x + 20.0f, position1.y, position1.z);
		newPosition = position1;
		ChangeTarget ();


	}



	// Update is called once per frame
	void FixedUpdate () {
		if (isTriggered) {
			
			transform.position = Vector3.MoveTowards (transform.position, newPosition, 10 * Time.deltaTime); 
		}
	}


	void ChangeTarget(){
		if (isTriggered) {
			if (currentState == "Moving To Position 1") {
			
				currentState = "Moving To Position 2";
				newPosition = position2;
			} else if (currentState == "Moving To Position 2") {
			
				currentState = "Moving To Position 1";
				newPosition = position1;

			} else if (currentState == "") {
			
				currentState = "Moving To Position 2";
				newPosition = position2;
			}
			Invoke ("ChangeTarget", 3);
		} else {
			Invoke ("ChangeTarget",0);
		}
	


	}
}
