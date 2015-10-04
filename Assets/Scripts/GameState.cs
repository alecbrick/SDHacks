using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameState : MonoBehaviour {

	public Text textBox;
	public ItemList items;

	private Item curr;
	private string theirs;

	// Use this for initialization
	void Start () {
		curr = items.getRandomItem ();
	}
	
	// Update is called once per frame
	void Update () {
		if (theirs != null) {
			textBox.text = theirs;
		}

		PhotonView pView = this.GetComponent<PhotonView> ();
		pView.RPC ("updateTheirItem", PhotonTargets.Others, curr.name);
	}

	[PunRPC]
	public void nextItem() {
		items.addItem ();
		curr = items.getRandomItem (curr);
	}

	[PunRPC]
	public void updateTheirItem(string t) {
		theirs = t;
		textBox.text = theirs;
	}
	
	public Item getCurrItem() {
		return curr;
	}

	public string getTheirItem() {
		return theirs;
	}
}
