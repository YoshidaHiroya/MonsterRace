using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shingouScript : MonoBehaviour {
	public bool start;
	private GameObject count;
	SpriteRenderer MainSpriteRenderer;
	public Sprite StandbySprite;
	public Sprite HoldSprite;
	public Sprite SlashSprite;
	private GameObject inustart;
	private GameObject hitsujistart;
	private GameObject rakudastart;
	private GameObject doragonstart;
	private GameObject hitostart;
	private GameObject textstart;
	void Start () {
		MainSpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
	}



	void Update () {
	if(start==true){

			this.gameObject.GetComponent<SpriteRenderer> ().enabled = true;
			MainSpriteRenderer.sprite = StandbySprite;
			StartCoroutine (wait());
			//音を鳴らす
			//音を鳴らす
			//音を鳴らす

		
		}
	}

	private IEnumerator wait () {
		yield return new WaitForSeconds (0.7f);
		MainSpriteRenderer.sprite = HoldSprite;
		yield return new WaitForSeconds (0.7f);
		MainSpriteRenderer.sprite = SlashSprite;
		yield return null;

		inustart= GameObject.Find ("inu");//犬だけじゃなくて他の動物もRaceStartをやる必要があり
		hitsujistart= GameObject.Find ("hitsuji");
		rakudastart= GameObject.Find ("rakuda");
		doragonstart= GameObject.Find ("doragon");
		hitostart= GameObject.Find ("hito");
		textstart= GameObject.Find ("ButtonText");
		inustart.GetComponent<inuSpeed>().RaceStart = true;
		hitsujistart.GetComponent<hitsujiSpeed>().RaceStart = true;
		rakudastart.GetComponent<rakudaSpeed>().RaceStart = true;
		doragonstart.GetComponent<doragonSpeed>().RaceStart = true;
		hitostart.GetComponent<hitoSpeed>().RaceStart = true;
		textstart.GetComponent<TextScript>().start = true;
		start = false;
	}


}
