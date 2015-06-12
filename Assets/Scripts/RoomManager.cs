using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RoomManager : MonoBehaviour {

	public bool isInterior = false; // 今もようがえ中？

	public static List<Sprite> PlayerItemList; // プレイヤーが持っているアイテム


	// Use this for initialization
	void Start () {
		PlayerItemList = new List<Sprite>();
		//Debug.Log ("RoomManager "+PlayerItemList.Count);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Interior () {

		isInterior = true;

	}
}
