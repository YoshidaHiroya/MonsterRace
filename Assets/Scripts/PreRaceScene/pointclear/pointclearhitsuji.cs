using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class pointclearhitsuji : MonoBehaviour {
	public Text counttext;
	public int point;

	private GameObject point_hitsuji;
	// Use this for initialization
	void Start () {
		point_hitsuji=GameObject.Find ("Pointput");
	}
	
	// Update is called once per frame
	public void OnClickButton(){
		point = point_hitsuji.GetComponent<Pointput> ().hitsuji;
		point =0;
		counttext.text = point.ToString ();
		Debug.Log (point);
		point_hitsuji.GetComponent<Pointput> ().hitsuji=point;
	}
}
