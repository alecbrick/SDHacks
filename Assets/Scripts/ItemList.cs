using UnityEngine;
using System.Collections;

public class ItemList : MonoBehaviour {
	public Item[] items;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public Item getRandomItem() {
		return items[Random.Range (0, items.Length - 1)];
	}

	// Get random item that isn't "i"
	public Item getRandomItem(Item i) {
		while (true) {
			Item it = getRandomItem ();
			if (!it.Equals (i)) {
				return it;
			}
		}
	}
}
