using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasDont : MonoBehaviour {
	public static bool eSuzdadenno = false;
	void Start () {
		if (eSuzdadenno == false) {
			DontDestroyOnLoad (transform.gameObject);
			eSuzdadenno = true;
		} 
		else {
			Destroy (gameObject);
		}
	}
}
