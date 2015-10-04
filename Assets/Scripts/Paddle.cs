using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 mouse = Input.mousePosition;
		Vector3 pt = Camera.main.ScreenToWorldPoint (mouse);
		pt.z = -6.0f;
		transform.position = pt;
	}
}
