﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class pointbet_1hito : MonoBehaviour {
	public Text counttext;
	public int point;
	private GameObject point_hito;
	// Use this for initialization
	void Start () {
		point_hito=GameObject.Find ("Pointput");
	}
	
	// Update is called once per frame
	public void OnClickButton(){
		point = point_hito.GetComponent<Pointput> ().hito;
		point += 1;
		counttext.text = point.ToString ();
		Debug.Log (point);
		point_hito.GetComponent<Pointput> ().hito=point;
	}
}
