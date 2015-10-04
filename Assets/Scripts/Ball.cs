using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	public Vector3 direction;
	public float delta;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		transform.position += direction * delta;
	}

	void OnTriggerEnter (Collider other) {
		
	}

	public void changeDirection (Vector3 dir) {
		direction = Vector3.Scale (direction, dir);
	}
}
