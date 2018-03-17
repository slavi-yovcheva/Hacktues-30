using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Varna : MonoBehaviour 
{	public Button button;
	// Use this for initialization
	void Start () 
	{
		Button btn = button.GetComponent<Button> ();
		btn.onClick.AddListener (TaskOnClick);

	}

	public void TaskOnClick () 
	{
		SceneManager.LoadScene ("Varna", LoadSceneMode.Single);
	}
}
