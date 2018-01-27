using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterHolder : MonoBehaviour {

	void OnTriggerEnter(Collider c){
		if(!c.gameObject.CompareTag("Fire"))
			c.transform.parent = gameObject.transform;
	}

	void OnTriggerExit(Collider c){
		c.transform.parent = null;
	}
}
