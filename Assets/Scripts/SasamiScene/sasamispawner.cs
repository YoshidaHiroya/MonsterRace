using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sasamispawner : MonoBehaviour {
	public GameObject sasami;
	public float speed=4.0f;
	// Use this for initialization
	void Start () {
		Instantiate (sasami,this.transform.position+this.transform.right,this.transform.rotation);

	//	Instantiate (sasami,this.transform.position+this.transform.right*0.5f,this.transform.rotation);
	//	Instantiate (sasami,this.transform.position+this.transform.right*1.5f,this.transform.rotation);
	//	Instantiate (sasami,this.transform.position-this.transform.right*2.0f,this.transform.rotation);
	//	Instantiate (sasami,this.transform.position-this.transform.right*2.5f,this.transform.rotation);

		//	this.gameObject.GetComponent<Rigidbody> ().velocity =	new Vector3 (-speed, 2, 0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
