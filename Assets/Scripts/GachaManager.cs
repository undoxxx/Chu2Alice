using UnityEngine;
using System.Collections;
using System.Collections.Generic;

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

		Debug.Log ("Gacha end");
	}

	// 画面にガチャ結果を表示するよ
	public void GachaResult () {

		Debug.Log ("GachaResult start");



		Debug.Log ("GachaResult start");

	}

}
