using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Продължение : MonoBehaviour 
{
	public Button button;
	// Use this for initialization
	void Start () 
	{
		Button btn = button.GetComponent<Button> ();
		btn.onClick.AddListener (TaskOnClick);

	}
	
	// Update is called once per frame
	void TaskOnClick () 
	{
		SceneManager.LoadScene ("Bulgaria", LoadSceneMode.Single);
	}
}
