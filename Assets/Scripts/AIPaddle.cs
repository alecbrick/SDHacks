using UnityEngine;
using System.Collections;

public class AIPaddle : MonoBehaviour {

	public Transform ball;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float newx = transform.position.x;
		float newy = transform.position.y;
		if (ball.position.x > -2.5 && ball.position.x < 2.5) {
			newx = ball.position.x;
		}
		if (ball.position.y > .5 && ball.position.y < 5.5) {
			newy = ball.position.y;
		}
		transform.position = new Vector3 (newx, newy, transform.position.z);
	}
}
