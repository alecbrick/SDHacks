using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameState : MonoBehaviour {

	public Text textBox;
	public ItemList items;

	private Item curr;

	// Use this for initialization
	void Start () {
		curr = items.getRandomItem ();
		textBox.text = curr.name;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void nextItem() {
		curr = items.getRandomItem (curr);
		textBox.text = curr.name;
	}

	public Item getCurrItem() {
		return curr;
	}
}
