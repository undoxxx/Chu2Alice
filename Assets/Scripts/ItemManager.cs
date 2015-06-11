using UnityEngine;
using System.Collections;

public class ItemManager : MonoBehaviour {

	public System.Collections.Generic.List<string> ItemType = { Table, Chair, Sofa, Other };

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

}
