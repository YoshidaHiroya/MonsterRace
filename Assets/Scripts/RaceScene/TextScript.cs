using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class TextScript : MonoBehaviour {
	public Text text;
	public bool start;
	public bool end;
	public bool hito;
	public bool inu;
	public bool hitsuji;
	public bool rakuda;
	public bool doragon;
	public bool ichi;
	public int hitopoint;
	public int inupoint;
	public int hitsujipoint;
	public int rakudapoint;
	public int doragonpoint;
	int a;
	int b;
	int c;
	int d;
	int e;
	int f;
	int i;

	int score;

	// Use this for initialization
	void Start () {

	}
	private IEnumerator Sample () {
		yield return new WaitForSeconds (3.0f);
		ichi = true;
		SceneManager.LoadScene ("MenuScene");
	}


	// Update is called once per frame
	void Update () {
		if (start == true) {
			text = this.GetComponent<Text> ();
			text.text = "レース開始 !"; 
			start = false;
		}
		if(end==true&&doragon==true&&ichi==false){
				text = this.GetComponent<Text>();
				text.text = "一位はドラゴンです!" +
					"ざんねんでした！"; 

			ichi = true;
			StartCoroutine (Sample());
		}
		if (end == true && hito == true && ichi == false) {
			text = this.GetComponent<Text> ();
			text.text = "一位は人間です!" +
			"おめでとうございます！";

			ichi = true;
			StartCoroutine (Sample());
			SceneManager.LoadScene ("Staff");

			ichi = true;

		}








		if(end==true&&inu==true&&ichi==false){
			text = this.GetComponent<Text>();
			text.text = "一位は犬です!" +
				"ざんねんでした！"; 

			ichi = true;

			StartCoroutine (Sample());

			ichi = true;
		}
		if(end==true&&rakuda==true&&ichi==false){
			text = this.GetComponent<Text>();
			text.text = "一位はラクダです!" +
				"ざんねんでした！"; 

			ichi = true;
			StartCoroutine (Sample());
		}

	if(end==true&&hitsuji==true&&ichi==false){
		text = this.GetComponent<Text>();
		text.text = "一位は羊です!" +
			"ざんねんでした！"; 
		

			ichi = true;
			StartCoroutine (Sample());

	}
	}
}
