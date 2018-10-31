using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class run : MonoBehaviour {
	private GameObject spe;
	float a;
	float s;
	// Use this for initialization
	void Start () {
		spe=GameObject.Find ("hito");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void OnClickButton(){
		a=Random.Range(1.0f, 6.5f);
		if (a > 2.5) {
			s = spe.GetComponent<hitoSpeed> ().Speed;  
			spe.GetComponent<hitoSpeed> ().Speed = s+0.2f;
		}
	}

}
