using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sasamiCreate : MonoBehaviour {
	float T;
	public GameObject sasami;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		T += Time.deltaTime;
			if(T>1.0f){
			Instantiate (sasami);
			T = 0;
			}
				
	}
}
