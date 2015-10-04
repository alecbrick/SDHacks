using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour {

	public string name;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public bool Equals (Item i) {
		return this.name.Equals (i.name);
	}
}
