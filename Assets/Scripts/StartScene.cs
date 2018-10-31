using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class StartScene : MonoBehaviour {
	int score=0;
	// Use this for initialization
	void Start () {
		PlayerPrefs.SetInt ("score",score);

	}
	
	// Update is called once per frame
	public void StartButton(){
		PlayerPrefs.SetInt ("score",score);
		SceneManager.LoadScene("Main");
	}

}
