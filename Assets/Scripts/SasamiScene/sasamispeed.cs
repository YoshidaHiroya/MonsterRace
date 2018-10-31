using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sasamispeed : MonoBehaviour {
	public GameObject sasami;
	public float speed=4.0f;
	public float timeOut=2.0f;
	private float timeElapsed=0.0f;
	public AudioClip warning;
	AudioSource audioSource;
	// Use this for initialization
	void Start () {
		audioSource=this.gameObject.GetComponent<AudioSource>();
		audioSource.clip = warning;
		audioSource.Play ();
	
	}
	
	// Update is called once per frame
	void Update () {

		timeElapsed += Time.deltaTime;

		if (timeElapsed>4.0f) {
			this.gameObject.GetComponent<Rigidbody> ().velocity =	new Vector3 (-speed, 0, 0);


		}

/*		if (timeElapsed >= timeOut) {
			
		this.gameObject.GetComponent<Rigidbody> ().velocity =	new Vector3 (-speed*3, 0, 0);

		}
*/
	}
}
