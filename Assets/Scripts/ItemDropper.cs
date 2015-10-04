using UnityEngine;
using System.Collections;

public class ItemDropper : MonoBehaviour {

	public ItemList itemList;
	private int t = 0;
	public Conveyor conveyor;
	public int rate;

	// Use this for initialization
	void Start () {
		t = rate;
	}
	
	// Update is called once per frame
	void Update () {
		if (t == 0) {
			Item i = (Item)GameObject.Instantiate (itemList.getRandomItem(), transform.position, Quaternion.identity);
			conveyor.addItem(i);
			t = rate;
		} else {
			t--;
		}
	}
}
