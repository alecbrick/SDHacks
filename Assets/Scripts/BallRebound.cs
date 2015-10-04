using UnityEngine;
using System.Collections;

public class BallRebound : MonoBehaviour {

	public Vector3 direction;
	private Ball ball;

	private bool debounce = true;

	// Use this for initialization
	void Start () {
		ball = (Ball)transform.GetComponentInParent<Ball>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider other) {
		if (debounce) {
			ball.changeDirection (direction);
			debounce = false;
		}
	}

	void OnTriggerExit (Collider other) {
		debounce = true;
	}
}
