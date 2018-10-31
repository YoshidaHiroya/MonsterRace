using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class staff_menu : MonoBehaviour {
	int a;
	// Use this for initialization
	void Start () {
		a = 0;
		PlayerPrefs.SetInt ("score", a);
		a=PlayerPrefs.GetInt ("score");
		a += 1;
		PlayerPrefs.SetInt ("score", a);
		Debug.Log (a);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void StartButton(){

		SceneManager.LoadScene("MenuScene");
	}
}
