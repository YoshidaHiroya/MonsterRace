﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class iribeScript : MonoBehaviour {
	Animator animator;
	Rigidbody rb;
	GameObject good;
	GameObject good2;
	GameObject good3;
	// Use this for initialization
	void Start () {
		animator = this.gameObject.GetComponent<Animator> ();
		rb = this.gameObject.GetComponent<Rigidbody> ();
		good = GameObject.Find ("good");
		good2 = GameObject.Find ("good2");	
		good3 = GameObject.Find ("good3");

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("right")) {
			this.transform.position += new Vector3 (1,0,0);
			this.transform.localScale = new Vector3 (4.32f, 3.95f, 1);
			animator.SetBool ("walkright", true);
		}

		if (Input.GetKeyDown ("left")) {
			this.transform.position += new Vector3 (-1,0,0);
			this.transform.localScale = new Vector3 (-4.32f, 3.95f, 1);

			animator.SetBool ("walkright", false);

		}
		if (Input.GetKeyDown ("space")) {
			rb.velocity = new Vector3 (0,3,0);
		}
	}
	void OnCollisionEnter(Collision collision){
		if (collision.gameObject.tag == "sasami") {
			good.GetComponent<Image> ().enabled = true;
			Destroy (collision.gameObject);

			if (collision.gameObject.tag == "sasami2") {
				good2.GetComponent<Image> ().enabled = true;
				Destroy (collision.gameObject);
		}

			if (collision.gameObject.tag == "sasami3") {
				good3.GetComponent<Image> ().enabled = true;
				Destroy (collision.gameObject);
	}

}
	}
}
