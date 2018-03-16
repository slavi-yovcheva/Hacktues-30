using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Blagoevgradska : MonoBehaviour 
{		
	public Sprite sprite1;
	public SpriteRenderer spriteRenderer;
	// Use this for initialization
	void Start () 
	{
		Button btn = GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}
	
	// Update is called once per frame
	void TaskOnClick()
	{
		spriteRenderer.sprite = sprite1;
	}
}
