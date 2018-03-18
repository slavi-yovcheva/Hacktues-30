﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class VarnaProverka : MonoBehaviour 
{
	public Button button;

	void Start () 
	{
		Button btn = button.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}
		
	public void TaskOnClick () 
	{
		SceneManager.LoadScene("Varna.Vupros", LoadSceneMode.Single);
	}
}