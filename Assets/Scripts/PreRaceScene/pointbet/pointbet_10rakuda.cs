using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class pointbet_10rakuda : MonoBehaviour {
	public Text counttext;
	public int point;
	private GameObject point_rakuda;
	// Use this for initialization
	void Start () {

		point_rakuda=GameObject.Find ("Pointput");
	}
	
	// Update is called once per frame
	public void OnClickButton(){
		point = point_rakuda.GetComponent<Pointput> ().rakuda;
		point += 10;
		counttext.text = point.ToString ();
		Debug.Log (point);
		point_rakuda.GetComponent<Pointput> ().rakuda=point;
	}
}
