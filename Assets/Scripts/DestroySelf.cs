using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySelf : MonoBehaviour {

	// Use this for initialization
	public float timeDelay = 30.0f;
	
	// Update is called once per frame
	void Update () {

		timeDelay -= Time.deltaTime;
		if (timeDelay <= 0) {
			Destroy (gameObject);
		}
		
	}
}
