using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class pointbet_100inu:MonoBehaviour {
	public Text counttext;
	public int point;

	private GameObject point_inu;
	// Use this for initialization
	void Start () {
		point_inu=GameObject.Find ("Pointput");
	}
	
	// Update is called once per frame
	public void OnClickButton(){
		point = point_inu.GetComponent<Pointput> ().inu;
		point += 100;
		counttext.text = point.ToString ();
		Debug.Log (point);
		point_inu.GetComponent<Pointput> ().inu=point;
	}
}
