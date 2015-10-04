using UnityEngine;
using System.Collections;

public class ItemChecker : MonoBehaviour {
	public GameState state;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		if (other.GetComponent<Item> () == null) {
			return;
		}
		Item item = (Item)other.GetComponent<Item> ();
		if (item.Equals (state.getCurrItem ())) {
			this.state.nextItem ();
		}
	}
}
