using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Burgas : MonoBehaviour 
{	public Button button;

	// Use this for initialization
	void Start () 
	{
		Button btn = button.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}
	
	// Update is called once per frame
	public void TaskOnClick () 
	{
		SceneManager.LoadScene("Burgas", LoadSceneMode.Single);
	}
}
