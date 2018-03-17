using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerButton : MonoBehaviour {
	public Button correctBtn;
	public Button wrongBtn;
	public int score = 0;
	void Start(){
		correctBtn.onClick.AddListener (onCorrectPressed);
	}

	public void onCorrectPressed(){
		Debug.Log ("Верен отговор!");
		score += 10;
	}
	public void onWrongPressed(){
		Debug.Log ("Грешен отговор!");
	}

	// Use this for initialization

	
	// Update is called once per frame

}
