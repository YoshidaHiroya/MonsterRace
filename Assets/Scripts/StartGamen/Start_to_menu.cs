using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Start_to_menu : MonoBehaviour {
	int a;
	// Use this for initialization
	void Start () {
		a = 0;
		PlayerPrefs.SetInt ("score", a);
	}
	
	// Update is called once per frame
	public void StartButton(){
		
		SceneManager.LoadScene("MenuScene");
	}

}
