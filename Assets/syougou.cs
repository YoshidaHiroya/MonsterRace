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
			text.text = "弱い";
		}
		if (a == 2) {
			text.text = "ふつう";
		}
		if (a == 3) {
			text.text = "ちょっと強い";
		}

		if (a == 4) {
			text.text = "強い";
		}
		if (a == 5) {
			text.text = "めっちゃ強い";
		}
		if (a == 6) {
			text.text = "最強";
		}
	}
}
