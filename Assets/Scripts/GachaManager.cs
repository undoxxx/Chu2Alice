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

		// ItemSpriteListに入ってるスプライトからランダムで選ぶよ
		int selectSprite = Mathf.FloorToInt ( (Random.value * 100) + 1f ) % ItemManager.ItemSpriteList.Count;
		Sprite gachaResultItem = ItemManager.ItemSpriteList[selectSprite];
		Debug.Log (gachaResultItem);

		// 画面にガチャ結果を表示するよ
		
		// uGUIで作ると簡単らしいよ

		// RoomManagerのPlayerItemListに追加するよ
		RoomManager.PlayerItemList.Add (gachaResultItem);
	}

}
