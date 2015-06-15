using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class GachaManager : MonoBehaviour {

	Sprite gachaResultItem; // ガチャ結果
	public Image _ImageItem;
	int selectSprite;

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
		selectSprite = Mathf.FloorToInt ( (Random.value * 100) + 1f ) % ItemManager.itemSprites.Length;
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
		_ImageItem.sprite = ItemManager.itemSprites[selectSprite];
		Debug.Log ("GachaResult GachaResultのImageItemをガチャ結果に入れ替えるよ");

		// GachaResultを表示するよ
		GameObject.Find("Canvas-Gacha").GetComponent<Canvas>().enabled = true;


		Debug.Log ("GachaResult end");

	}
}
