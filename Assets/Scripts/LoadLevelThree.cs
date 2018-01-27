using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadLevelThree : MonoBehaviour {


	void OnTriggerEnter(Collider c){
		Debug.Log ("Next Level!");
		SceneManager.LoadScene("level 3");
	}
}
