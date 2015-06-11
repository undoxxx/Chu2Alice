using UnityEngine;
using System.Collections;

public class GachaManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// ガチャ回すよ
	public void Gacha () {

		Random rand = new Random();
		
		// ItemListに入ってるスプライトからランダムで選ぶよ

			// まずどのタイプのアイテムか選ぶよ

			int choseType = Mathf.FloorToInt ((Random.value * 100) + 1f) % ItemManager.ItemType.Count;
			Debug.Log (choseType);
		
			// 何番目にするか選ぶよ

			ItemTableList;
			ItemChairList;
			ItemSofaList;
			ItemOtherList;

			int choseNum = Mathf.FloorToInt ((Random.value * 100) + 1f) % ItemManager.ItemType.Count;
			Debug.Log (choseNum);
		
		// 画面に結果を表示するよ
		
		// uGUIで作ると簡単らしいよ
			
		// 出てきたのをPrefab化するよ

		// RoomManagerのPlayerItemListに追加するよ
		/*
			Sprite spriteImage = Resources.Load("Sprite/test", typeof(Sprite)) as Sprite;
			new GameObject("Sprite").AddComponent<SpriteRenderer>().sprite = spriteImage;
		*/
	}
}
