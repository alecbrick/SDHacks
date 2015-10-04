using UnityEngine;
using System.Collections;

public class ItemList : MonoBehaviour {
	public Item[] items;
	private int currLen;
	// Use this for initialization
	void Start () {
		currLen = 2;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public Item getRandomItem() {
		return items[Random.Range (0, currLen)];
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

	public void addItem() {
		if (currLen < items.Length) {
			currLen++;
		}
	}
}
