using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class iribeScript : MonoBehaviour {
	Animator animator;
	Rigidbody rb;
	GameObject good;
	GameObject good2;
	GameObject good3;
	int a;
	SpriteRenderer MainSpriteRenderer;
	public Sprite GorilaSprite;
	int count;
	// Use this for initialization
	void Start () {
		animator = this.gameObject.GetComponent<Animator> ();
		rb = this.gameObject.GetComponent<Rigidbody> ();
		good = GameObject.Find ("good");
		good2 = GameObject.Find ("good2");	
		good3 = GameObject.Find ("good3");
		MainSpriteRenderer = gameObject.GetComponent<SpriteRenderer>();

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

		if (count == 3) {
			ChangeStateToHold ();

			animator.SetBool ("gorila", true);


			a=PlayerPrefs.GetInt ("score");
			a += 1;
			PlayerPrefs.SetInt ("score", a);





		}




	}
	void OnCollisionEnter(Collision collision){
		if (collision.gameObject.tag == "sasami") {
			good.GetComponent<Image> ().enabled = true;
			Destroy (collision.gameObject);
			count += 1;
		}
		if (collision.gameObject.tag == "sasami2") {
				good2.GetComponent<Image> ().enabled = true;
				Destroy (collision.gameObject);
			count += 1;
		}

		if (collision.gameObject.tag == "sasami3") {
				good3.GetComponent<Image> ().enabled = true;
				Destroy (collision.gameObject);
			count += 1;
		}



	}
	void ChangeStateToHold()
	{
		// SpriteRenderのspriteを設定済みの他のspriteに変更
		// 例) HoldSpriteに変更
		MainSpriteRenderer.sprite = GorilaSprite;
	}

}

