using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class GachaManager : MonoBehaviour {

	Sprite gachaResultItem; // ガチャ結果
	Image _ImageItem;

	// Use this for initialization
	void Start () {

		_ImageItem = (Image)FindObjectOfType<Image> ("ImageItem");

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// ガチャ回すよ
	public void Gacha () {

		Debug.Log ("Gacha start");

		// ItemSpriteListに入ってるスプライトからランダムで選ぶよ
		int selectSprite = Mathf.FloorToInt ( (Random.value * 100) + 1f ) % ItemManager.itemSprites.Length;
		gachaResultItem = ItemManager.itemSprites[selectSprite];
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
		_ImageItem.GetComponent<Image>().sprite = gachaResultItem;
		Debug.Log ("GachaResult GachaResultのImageItemをガチャ結果に入れ替えるよ");

		// GachaResultを表示するよ
		//GameObject.Find("GachaResult").GetComponent<Canvas>().enabled = true;


		Debug.Log ("GachaResult end");

	}

	// ガチャ結果画面を非表示にするよ
	public void GachaResultAway () {

	}

}
