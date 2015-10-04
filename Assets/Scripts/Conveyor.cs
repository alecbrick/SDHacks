using UnityEngine;
using System.Collections;

public class Conveyor : MonoBehaviour {

	private ArrayList items;
	private ArrayList newItems;
	public float rbound;
	public float delta;


	// Use this for initialization
	void Start () {
		items = new ArrayList ();
	}
	
	// Update is called once per frame
	void Update () {
		newItems = new ArrayList();
		foreach (Item i in items) {
			if (i.transform.position.y > 0) {
				i.transform.position = i.transform.position + Vector3.right * delta;
				newItems.Add (i);
			} else {
				Destroy (i.gameObject);
			}
			if (i.transform.position.x > rbound && (i.GetComponent<Rigidbody>() == null)) {
				i.gameObject.AddComponent<Rigidbody>();
			}
		}
		items = newItems;
	}

	public void addItem(Item item) {
		items.Add (item);
	}
}
