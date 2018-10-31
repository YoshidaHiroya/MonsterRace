using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Asobikata : MonoBehaviour {

	public Text text;

	// Use this for initialization
	void Start () {
		// テキストを文字の状態によって変更するようにします。
		//var components = this.gameObject.GetComponentsInChildren<Text>();
	//	components[0].text ="人は動物に勝てるのかを遊んでいただきありがとうございます！\n\n\t\tここではこのゲームの遊び方を説明し。";

	}
	
	// Update is called once per frame
	public void OnClickButton()
	{
		
			// Textコンポーネント郡を取得します。
		Text[] components = this.gameObject.GetComponentsInChildren<Text>();
			// テキストを文字の状態によって変更するようにします。
		components[0].text ="このゲームは人VSそれ以外の動物のレースゲームです。「走るボタン」を連打することにより" +
			"、レースで一位をとりましょう！";
		
	//	var components = this.gameObject.GetComponentsInChildren<Text>();
		// Textコンポーネント郡を取得します。
	//	components[0].text ="あいうえお";

		// テキストを文字の状態によって変更するようにします。
	}

		//GameObject canvas = GameObject.Find("Canvas");
		// Textコンポーネント郡を取得します。
		//var components = this.gameObject.GetComponentsInChildren<Text>();
		// テキストを文字の状態によって変更するようにします。
		//components[0].text ="あいうえお";
		//Button.GetComponentInChildren<Text>().text = "test";
//		Text text = canvas.GetComponentsInChildren<Text>();
//		text.text="あいうえお";
		// テキストを文字の状態によって変更するようにします。
		//text.text="あいうえお";
		//text.text = "あいうえお"; 
	}
	

