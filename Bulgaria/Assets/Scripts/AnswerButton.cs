using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AnswerButton : MonoBehaviour {
	public Button correctBtn;
	public Button wrongBtn;
	public int score = 0;
	void Start()
	{
		correctBtn.onClick.AddListener (onCorrectPressed);
		wrongBtn.onClick.AddListener (onWrongPressed);
	}

	public void onCorrectPressed()
	{
			SceneManager.LoadScene ("Veren.Otgovor", LoadSceneMode.Single);
	}

	public void onWrongPressed()
	{
		SceneManager.LoadScene ("Greshen.Otgovor", LoadSceneMode.Single);
	}

	// Use this for initialization

	
	// Update is called once per frame

}
