﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ProverkaKystendil : MonoBehaviour {

	public Button button;

	// Use this for initialization
	void Start () 
	{
		Button btn = button.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	// Update is called once per frame
	public void TaskOnClick () 
	{
		SceneManager.LoadScene("KystendilVuprosi", LoadSceneMode.Single);
	}
}
