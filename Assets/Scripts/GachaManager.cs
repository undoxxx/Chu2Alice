using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class GachaManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// ガチャ回すよ
	public void Gacha () {

		Debug.Log ("Gacha start");

		// ItemSpriteListに入ってるスプライトからランダムで選ぶよ
		int selectSprite = Mathf.FloorToInt ( (Random.value * 100) + 1f ) % ItemManager.itemSprites.Length;
		Sprite gachaResultItem = ItemManager.itemSprites[selectSprite];
		Debug.Log (gachaResultItem);

		// PlayerItemListに追加するよ
		RoomManager.PlayerItemList.Add (gachaResultItem);
		Debug.Log ("Gacha RoomManager.PlayerItemList.Add (gachaResultItem);");

		GachaResult ();
		Debug.Log ("GachaResult();");

		Debug.Log ("Gacha end");
	}

	// ガチャ結果画面を表示するよ
	public void GachaResult () {

		Debug.Log ("GachaResult start");

		// GachaResultのImageItemをガチャ結果に入れ替えるよ

		
		// GachaResultを表示するよ
		GameObject.Find("GachaResult").GetComponent<Canvas>().enabled = true;

		/*
		this.gameObject.SetActive(true);
			InitIcons();
			boad.Close();
			explanationImage.gameObject.SetActive(!achievement.IsOpenedOnceAchievement);

		foreach (Transform child in canvas.transform){
			if(child.name == "Button1"){
				Button button1 = child.gameObject.GetComponent<Button>();
				button1.gameObject.SetActive (true);
			}
		}
		*/


		Debug.Log ("GachaResult start");

	}

	//ガチャ結果画面を閉じる
	public void Close()
	{
		this.gameObject.SetActive(false);
	}

}
