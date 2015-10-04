using UnityEngine;
using System.Collections;

public class ItemDropper : MonoBehaviour {

	public ItemList itemList;
	private Item[] items;
	private int t = 0;
	public Conveyor conveyor;
	public int rate;

	// Use this for initialization
	void Start () {
		t = rate;
		items = itemList.items;
	}
	
	// Update is called once per frame
	void Update () {
		if (t == 0) {
			Item i = (Item)GameObject.Instantiate (items [Random.Range (0, items.Length - 1)], transform.position, Quaternion.identity);
			conveyor.addItem(i);
			t = rate;
		} else {
			t--;
		}
	}
}
