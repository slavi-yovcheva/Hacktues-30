﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Sofia : MonoBehaviour 
{	
	public Button button;

	void Start () 
	{
		Button btn = button.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}
		
	public void TaskOnClick () 
	{
		SceneManager.LoadScene("SofiaScene", LoadSceneMode.Single);
	}
}
