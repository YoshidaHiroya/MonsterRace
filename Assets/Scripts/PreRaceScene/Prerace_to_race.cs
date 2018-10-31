using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Prerace_to_race : MonoBehaviour {

	int hito;
	int inu;
	int hitsuji;
	int rakuda;
	int doragon;
	int hitotyoushi;
	int inutyoushi;
	int hitsujityoushi;
	int rakudatyoushi;
	int doragontyoushi;

	private GameObject point_hito;
	private GameObject tyoushihito;
		// Use this for initialization
		void Start () {
		}

		// Update is called once per frame
		public void StartButton(){//あとから参照できるように最終的なポイントを保存しておく。
		point_hito=GameObject.Find ("Pointput");
		//tyoushihito=GameObject.Find ("tyoshiput");
		hito = point_hito.GetComponent<Pointput> ().hito;
//		hitotyoushi = tyoushihito.GetComponent<tyoshiput> ().hito;

		//point_hito=GameObject.Find ("Pointput");
		inu = point_hito.GetComponent<Pointput> ().inu;

//		inutyoushi = tyoushihito.GetComponent<tyoshiput> ().inu;

		//point_hito=GameObject.Find ("Pointput");
		hitsuji = point_hito.GetComponent<Pointput> ().hitsuji;


//		hitsujityoushi = tyoushihito.GetComponent<tyoshiput> ().hitsuji;

		//point_hito=GameObject.Find ("Pointput");
		rakuda = point_hito.GetComponent<Pointput> ().rakuda;


//		rakudatyoushi = tyoushihito.GetComponent<tyoshiput> ().rakuda;
		//point_hito=GameObject.Find ("Pointput");
		doragon = point_hito.GetComponent<Pointput> ().doragon;
//		doragontyoushi = tyoushihito.GetComponent<tyoshiput> ().doragon;
		PlayerPrefs.GetInt ("hitobet",hito);
		PlayerPrefs.GetInt ("hitotyoushi",hitotyoushi);

		PlayerPrefs.GetInt ("inubet",inu);
		PlayerPrefs.GetInt ("inutyoushi",inutyoushi);


		PlayerPrefs.GetInt ("hitsujibet",hitsuji);
		PlayerPrefs.GetInt ("hitsujityoushi",hitsujityoushi);


		PlayerPrefs.GetInt ("rakudabet",rakuda);
		PlayerPrefs.GetInt ("rakudatyoushi",rakudatyoushi);


		PlayerPrefs.GetInt ("doragonbet",doragon);
		PlayerPrefs.GetInt ("doragontyoushi",doragontyoushi);



		SceneManager.LoadScene("RaceScene");
		}

	}
