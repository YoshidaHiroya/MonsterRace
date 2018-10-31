using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class point : MonoBehaviour {
	
	public Text pointtext;
	// Use this for initialization
	void Start () {
		pointtext.text = PlayerPrefs.GetInt ("score").ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
