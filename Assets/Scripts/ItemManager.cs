using UnityEngine;
using System.Collections;

public class ItemManager : MonoBehaviour {

	public System.Collections.Generic.List<Sprite> ItemTableList;
	public System.Collections.Generic.List<Sprite> ItemChairList;
	public System.Collections.Generic.List<Sprite> ItemSofaList;
	public System.Collections.Generic.List<Sprite> ItemOtherList;

	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void ItemListMaker(){

		System.Collections.Generic.List<GameObject> PlayerItemList;

		Sprite spriteImage = Resources.Load("Sprite/test", typeof(Sprite)) as Sprite;
		new GameObject("Sprite").AddComponent<SpriteRenderer>().sprite = spriteImage;
	}
}
