using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour {

	// Use this for initialization
	public float speed = 20.0f;
	public Vector3 newPosition;
	// Update is called once per frame
	void FixedUpdate () {
		newPosition = new Vector3 (transform.position.x - speed, transform.position.y, transform.position.z);
		transform.position = Vector3.MoveTowards (transform.position, newPosition, 10 * Time.deltaTime); 
		
	}
}
