using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameraposition : MonoBehaviour {

	public bool idou1;
	public bool idou2;
	public bool itiikita1;
	public bool itiikita2;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (idou1 == true&&itiikita1==false) {
			this.gameObject.GetComponent<Transform> ().position =new Vector3 (12.0f, 9.52f, 6.74f);
			itiikita1 = true;
		}
		if (idou2 == true&&itiikita2==false) {
			this.gameObject.GetComponent<Transform> ().position =new Vector3 (6.0f, 9.52f, 6.74f);
			itiikita2 = true;
		}
	}
}
