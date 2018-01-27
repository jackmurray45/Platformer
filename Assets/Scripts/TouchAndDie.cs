using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchAndDie : MonoBehaviour {

	public GameObject button;
	public GameObject text;
	void OnTriggerEnter(Collider c){
		if (c.gameObject.CompareTag ("Player")) {
			Time.timeScale = 0;
			if (button != null) {
				button.gameObject.SetActive (true);
				text.SetActive (true);
			}
			
		}
			
	}
}
