using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RestartScene : MonoBehaviour {

	public GameObject button;

	void Start(){
		button.gameObject.SetActive (false);
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
