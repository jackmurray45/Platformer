using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RestartLevelThree : MonoBehaviour {

	public GameObject button;
	public GameObject text;

	void Start(){
		button.gameObject.SetActive (false);
		text.gameObject.SetActive (false);
	}
	public void restartScene(){

		Scene loadedLevel = SceneManager.GetActiveScene ();
		Time.timeScale = 1;
		SceneManager.LoadScene (loadedLevel.buildIndex);
	}

	public void hello(){

		Debug.Log ("HELLO");
	}

}
