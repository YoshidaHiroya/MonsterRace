using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	private GameObject Maru;

	public float speed = 5.0f;
	public float velocitypower =20.0f;
	public int jumpCount=0;
	public AudioClip jumpSound;
	public AudioClip getCoin;
	public AudioClip huekansei;
	public AudioClip hassya;
	public bool Walkright;	
	public GameObject maru;
	AudioSource audioSource;
	Animator animator;
	int i=0;
	// Use this for initialization
	void Start () {
		audioSource=this.gameObject.GetComponent<AudioSource>();
		animator = this.gameObject.GetComponent<Animator> (); 

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("right") == true) {
			this.transform.position += new Vector3 (speed * Time.deltaTime, 0, 0);
		}

		if (Input.GetKeyDown("right") == true) {
			animator.SetBool ("Walkright", true);
		}

		if (Input.GetKeyUp ("right") == true) {
			animator.SetBool ("Walkright", false);
		}
			


		if (Input.GetKey ("left") == true) {
			this.transform.position -= new Vector3 (speed * Time.deltaTime, 0, 0);
		}
		if (Input.GetKeyDown ("space") == true&&jumpCount<2) {
			this.gameObject.GetComponent<Rigidbody> ().velocity = new Vector3 (0, velocitypower, 0);
			audioSource.clip  = jumpSound;
			audioSource.Play();
			jumpCount += 1;
		}

			}
	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "Ground") {
			jumpCount = 0;
		}
		if (col.gameObject.tag == "Coin") {
			audioSource.clip = getCoin;
			audioSource.Play ();
			audioSource.clip = huekansei;
			audioSource.Play ();
			Destroy (col.gameObject);

			i = i + 1;
			if (i == 1) {
				Maru = GameObject.Find ("maru");
				//gameObject.Find("maru").GetComponent.<Image>().enabled = false;
				//GameObject.Find("maru").GetComponent<Image>().enabled = false;
				Maru.GetComponent<SpriteRenderer> ().enabled = true;
				//private Image xxxImage;
				//kinniku = GameObject.Find ("kinniku").GetComponent<Image> ();
				//kinniku.sprite = "";

			}
			if (i == 2) {
				Maru = GameObject.Find ("maru2");
				Maru.GetComponent<SpriteRenderer> ().enabled = true;
			
			}

			if (i == 3) {
				Maru = GameObject.Find ("maru3");
				Maru.GetComponent<SpriteRenderer> ().enabled = true;

			}

			if (i == 4) {
				Maru = GameObject.Find ("maru4");
				Maru.GetComponent<SpriteRenderer> ().enabled = true;

			}

			if (i == 5) {
				Maru = GameObject.Find ("maru5");
				Maru.GetComponent<SpriteRenderer> ().enabled = true;

			}
		}



	}
}
