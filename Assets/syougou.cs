using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class syougou : MonoBehaviour {
	GameObject Syougou;
	Text text;
	int a;
	// Use this for initialization
	void Start () {
		Syougou = GameObject.Find ("syougou");
		text=Syougou.GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		a = PlayerPrefs.GetInt ("score");
		if (a == 1) {
			text.text = "ふつう";
		}
		if (a == 2) {
			text.text = "最強";
		}
	}
}
