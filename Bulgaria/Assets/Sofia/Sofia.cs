using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Sofia : MonoBehaviour 
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
		SceneManager.LoadScene("SofiaScene", LoadSceneMode.Single);
	}
}
