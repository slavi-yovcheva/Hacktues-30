using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AnswerButton : MonoBehaviour {
	public Button correctBtn;
	public Button wrongBtn; 
	GameObject score;
	ScorePoints scoreScript;
	Text text;

	void Start()
	{
		correctBtn.onClick.AddListener (onCorrectPressed);
		wrongBtn.onClick.AddListener (onWrongPressed);
		score = GameObject.Find ("ScoreText");
		scoreScript = score.GetComponent<ScorePoints>();
		text = score.GetComponent<Text>();
		 
	}

	public void onCorrectPressed()
	{
		scoreScript.points += 10;
		text.text = "Score: " + scoreScript.points;

		SceneManager.LoadScene ("Veren.Otgovor", LoadSceneMode.Single);

	
	}

	public void onWrongPressed()
	{
		SceneManager.LoadScene ("Greshen.Otgovor", LoadSceneMode.Single);
	}

	// Use this for initialization

	
	// Update is called once per frame

}
