using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitingCharacterHolder : MonoBehaviour {

	public GameObject PlatForm;
	public bool done = false;


	void OnTriggerEnter(Collider c){

		if(!c.gameObject.CompareTag("Fire"))
			c.transform.parent = gameObject.transform;
		if (!done) {
			if (c.gameObject.CompareTag ("Player")) {
				PlatForm.GetComponent<WaitingMovingPlatform> ().isTriggered = true;
				done = true;
			}
		}
	}

	void OnTriggerExit(Collider c){
		
		c.transform.parent = null;
	}

}
