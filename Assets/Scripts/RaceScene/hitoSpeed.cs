using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitoSpeed : MonoBehaviour {
	public float Speed =10.0f;
	public bool syokiichi;
	public bool RaceStart;
	private GameObject camera_idou1;
	private GameObject camera_idou2;
	private GameObject shingou;
	private GameObject textend;
	private int i;
	private int a;
	Animator animator;
	Rigidbody rigidbody;
	Transform transform;

	void Start () {
		animator = this.gameObject.GetComponent<Animator> ();
		StartCoroutine (Start_walk());
		rigidbody = this.gameObject.GetComponent<Rigidbody> ();
		transform = this.gameObject.GetComponent<Transform> ();
		textend= GameObject.Find ("ButtonText");
		//ここで初期位置まで歩かせるコルーチンが必要


	}


	void Update ()
	{


		if (syokiichi==true) {//初期位置まで移動できたらそこで止まらせる
			this.gameObject.GetComponent<Rigidbody> ().velocity =new Vector3 (0, 0, 0);
			animator.SetBool("walkRight",false);
			StartCoroutine (Sample());//開始位置で待機させるコルーチンを呼び出している
		}
		//ここよりうえはレースが始まるまでレース開始位置にラクダを配置



		if (RaceStart == true) {//信号が鳴りスタートしたら人を歩かせる
			this.gameObject.GetComponent<Rigidbody> ().velocity =new Vector3 (-Speed, 0, 0);
			animator.SetBool("walkRight",true);
			//レースが始まったらRaceStartがオフになるまで以下のRaceModeコルーチンに従い動く

			StartCoroutine (RaceMode());
			//RaceModeの中でRaceStartがオフになったらゴールで停止させる。

			if (RaceStart == false) {
				this.gameObject.GetComponent<Rigidbody> ().velocity =new Vector3 (0, 0, 0);
				animator.SetBool("walkRight",false);
				StartCoroutine (Goal());

			}
		}
		this.gameObject.GetComponent<Rigidbody> ().velocity =new Vector3 (0, 0, 0);
		animator.SetBool("walkRight",false);
	}




	//スタート位置まで移動させるコルーチン
	private IEnumerator Start_walk () {
		for (i = 0; i < 1000; i++) {
			this.gameObject.GetComponent<Rigidbody> ().velocity = new Vector3 (-Speed, 0, 0);
			animator.SetBool ("walkRight", true);
			if (this.gameObject.GetComponent<Transform> ().position.x < 25.0f && this.gameObject.GetComponent<Transform> ().position.x > 20.0f)
			{									//初期位置をx=25としてそこまであるかせてる
				syokiichi = true;
				i = i + 1000;
			}
			yield return null;
		}
	}



	//スタート前に待機させるためのコルーチン
	private IEnumerator Sample () {
		yield return new WaitForSeconds (3.0f);

		shingou = GameObject.Find ("shingou4");
		shingou.GetComponent<shingouScript> ().start = true;//スタート位置の信号機を点灯させる
		syokiichi = false;

		yield return null;
	}

	//レース中待機させるためのコルーチン
	private IEnumerator taiki_Race () {
		yield return new WaitForSeconds (1.5f);
		rigidbody.velocity =new Vector3 (0, 0, 0);
		animator.SetBool("walkRight",false);
		yield return null;
	}

	//レース中移動させるためのコルーチン
	private IEnumerator idou_Race () {
		yield return new WaitForSeconds (0.01f);
		rigidbody.velocity =new Vector3 (-Speed, 0, 0);
		animator.SetBool("walkRight",true);
		yield return null;
	}

	//ゴールしたら待機させるためのコルーチン
	private IEnumerator Goal () {

		textend.GetComponent<TextScript>().end = true;
		textend.GetComponent<TextScript>().hito = true;
		yield return new WaitForSeconds (3.0f);
		rigidbody.velocity =new Vector3 (0, 0, 0);
		animator.SetBool("walkRight",false);

		textend.GetComponent<TextScript>().end = true;
		textend.GetComponent<TextScript>().inu = true;
		yield return null;
	}







	//レース中の動き方のコルーチン
	private IEnumerator RaceMode () {
		for (i = 0; i < 1000; i++) {

			StartCoroutine (idou_Race ());
			if (transform.position.x < 15.0f&&transform.position.x > 4.0f) {

				camera_idou1 = GameObject.Find ("Main Camera");
				camera_idou1.GetComponent<Cameraposition> ().idou1 = true;
			}

			if (transform.position.x < 4.0f) {

				camera_idou2 = GameObject.Find ("Main Camera");
				camera_idou2.GetComponent<Cameraposition> ().idou2 = true;
			}
			StartCoroutine (taiki_Race ());


			if (transform.position.x < 0.0f) {
				i = i + 1000;
				RaceStart = false;
			}
		}
		yield return null;
	}

}
