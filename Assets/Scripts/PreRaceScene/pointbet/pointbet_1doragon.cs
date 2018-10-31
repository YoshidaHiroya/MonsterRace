using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class pointbet_1doragon: MonoBehaviour {
	public Text counttext;
	public int point;
	private GameObject point_doragon;
	// Use this for initialization
	void Start () {
		point_doragon=GameObject.Find ("Pointput");
	}
	
	// Update is called once per frame
	public void OnClickButton(){
		point = point_doragon.GetComponent<Pointput> ().doragon;
			point+=1;
		counttext.text = point.ToString ();
		Debug.Log (point);
		point_doragon.GetComponent<Pointput> ().doragon=point;
	}
}
