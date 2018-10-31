using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tyoushiinu : MonoBehaviour {
	public Sprite hutuuSprite;
	public Sprite yoiSprite;
	public Sprite hutyouSprite;
	//private GameObject bairitu_hito;
	SpriteRenderer MainSpriteRenderer;
	// Use this for initialization
	private GameObject tyoshi_inu;
	int tyoshi;
	public Text bairitu;
	void Start () {
		MainSpriteRenderer = gameObject.GetComponent<SpriteRenderer>();

		int var;
		var=Random.Range(1, 4);

		if (var == 3) {
			MainSpriteRenderer.sprite = hutyouSprite;
			tyoshi_inu=GameObject.Find ("tyoshiput");
			tyoshi_inu.GetComponent<tyoshiput> ().inu=var;
		}

		if (var == 2) {
			MainSpriteRenderer.sprite = hutuuSprite;
			tyoshi_inu=GameObject.Find ("tyoshiput");
			tyoshi_inu.GetComponent<tyoshiput> ().inu=var;
		}

		if (var == 1) {
			MainSpriteRenderer.sprite = yoiSprite;
			tyoshi_inu=GameObject.Find ("tyoshiput");
			tyoshi_inu.GetComponent<tyoshiput> ().inu=var;
		}
		bairitu.text = var.ToString();
		//bairitu_hito= GameObject.Find ("bairituhito");
	//	bairitu_hito.GetComponent<TextScript>().text=;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
