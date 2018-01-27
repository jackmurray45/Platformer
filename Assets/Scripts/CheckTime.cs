using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckTime : MonoBehaviour {

	public GameObject button;

	// Update is called once per frame
	void FixedUpdate () {
		if (Time.timeScale == 0) {
			Debug.Log ("TOUCHED!");
			button.gameObject.SetActive (true);
		}
		
	}
}
