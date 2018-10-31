using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pointput : MonoBehaviour {
	public int hito;
	public int inu;
	public int hitsuji;
	public int rakuda;
	public int doragon;
	// Use this for initialization
	void Start () {
		hito = 0;
		inu = 0;
		hitsuji = 0;
		rakuda = 0;
		doragon = 0;
	}
	
	// Update is called once per frame
	void Update () {
		PlayerPrefs.SetInt ("hitobet",hito);//ここで全部プレイヤーにいれておく

		PlayerPrefs.SetInt ("inubet", inu);

		PlayerPrefs.SetInt ("hitsujiobet", hitsuji);
		PlayerPrefs.SetInt ("rakudabet", rakuda);

		PlayerPrefs.SetInt ("doragonbet", doragon);

	
	
	
	
	
	}
}
