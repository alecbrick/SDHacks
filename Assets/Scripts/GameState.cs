using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameState : MonoBehaviour {

	public Text textBox;
	public ItemList items;

	private Item curr;
	private Item theirs;

	// Use this for initialization
	void Start () {
		curr = items.getRandomItem ();
	}
	
	// Update is called once per frame
	void Update () {
		if (theirs != null) {
			textBox.text = theirs.name;
		}
	}

	[PunRPC]
	public void nextItem() {
		items.addItem ();
		curr = items.getRandomItem (curr);
	}
	
	public Item getCurrItem() {
		return curr;
	}

	public Item getTheirItem() {
		return theirs;
	}

	void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info) {
		Debug.Log ("Ayy lmao");
		if (stream.isWriting) {
			stream.SendNext (curr);
		} else {
			theirs = (Item) stream.ReceiveNext();
		}
	}
}
