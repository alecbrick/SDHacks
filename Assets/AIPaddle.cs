﻿using UnityEngine;
using System.Collections;

public class AIPaddle : MonoBehaviour {

	public Transform ball;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (ball.position.x, ball.position.y, transform.position.z);
	}
}
