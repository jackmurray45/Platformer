using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevelTwo : MonoBehaviour {

	void OnTriggerEnter(Collider c){
		SceneManager.LoadScene ("Level 2");
			
	}
}
