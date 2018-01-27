using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Winner : MonoBehaviour {

	public GameObject winnerButton;
	public GameObject restartButton;
	public GameObject winnerText;
	public GameObject diedText;
	public Text win;
	// Use this for initialization
	void Start () {
		winnerButton.gameObject.SetActive (false);
		winnerText.gameObject.SetActive (false);
		win.GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void OnTriggerEnter(Collider c){
		
		Debug.Log ("HERE!");
		Time.timeScale = 0;
		win.text = "WINNER!";
		winnerText.gameObject.SetActive (true);
		Destroy (diedText);
		Destroy (restartButton);
		winnerButton.gameObject.SetActive (true);


	}

	public void restartGame(){
		Time.timeScale = 1;
		SceneManager.LoadScene ("level 1");
	}
}
