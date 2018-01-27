using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
	public GameObject loseText;
	public GameObject button;
	public Text timerText;
	public Text noTimeText;
	private float time = 30.0f;


	void Start(){
		timerText = GetComponent<Text> ();
		loseText.gameObject.SetActive (false);
	}

	// Update is called once per frame
	void Update () {
		time -= Time.deltaTime;
		timerText.text = "Time Left: "+time.ToString ("f0");
		if (Time.timeScale == 0)
			GameOver ();
		if(time < 0)
		{
			GameOver();
		}
		print (timerText);
	}

	void GameOver(){
		Time.timeScale = 0;
		if(button != null)
			button.gameObject.SetActive (true);
		if(loseText != null)
			loseText.gameObject.SetActive (true);

		if (time <= 0) {
			loseText.gameObject.GetComponent<Text> ().fontSize = 20;
			loseText.gameObject.GetComponent<Text> ().text = "Ran out of time! :(";


		}
		Destroy (gameObject);

	}
}
