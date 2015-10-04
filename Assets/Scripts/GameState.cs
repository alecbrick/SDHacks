using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameState : MonoBehaviour {

	public Text textBox;
	public ItemList items;

	private Item curr;
	private string theirs;

	int i;

	// Use this for initialization
	void Start () {
		curr = items.getRandomItem ();
		i = 100;
	}
	
	// Update is called once per frame
	void Update () {
		if (theirs != null) {
			textBox.text = theirs;
		}
		if (i == 0) {
			PhotonView pView = this.GetComponent<PhotonView> ();
			pView.RPC ("updateTheirItem", PhotonTargets.Others, curr.name);
			i = 100;
		}
		i--;
	}

	[PunRPC]
	public void nextItem() {
		items.addItem ();
		curr = items.getRandomItem (curr);

		PhotonView pView = this.GetComponent<PhotonView> ();
		Debug.Log (curr.name);
		pView.RPC ("updateTheirItem", PhotonTargets.Others, curr.name);
	}

	[PunRPC]
	public void updateTheirItem(string t) {
		theirs = t;
		textBox.text = theirs;
		Debug.Log (theirs);
	}
	
	public Item getCurrItem() {
		return curr;
	}

	public string getTheirItem() {
		return theirs;
	}
}
