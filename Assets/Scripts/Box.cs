using UnityEngine;
using System.Collections;

public class Box : MonoBehaviour {

	public Vector3 belt1;
	public Vector3 belt2;
	private int side;

	// Use this for initialization
	void Start () {
		side = 2;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.anyKeyDown) {
			switchBelts ();
		}
	}

	public void switchBelts() {
		switch (side) {
		case 1:
			side = 2;
			transform.position = belt2;
			break;
		case 2:
			side = 1;
			transform.position = belt1;
			break;
		}
	}

	private bool IsHand(Collider other){
    	if(other.transform.parent && other.transform.parent.parent && other.transform.parent.parent.GetComponent<HandModel>())
      		return true;
    	else{
      		return false;
  	  	}
  	}

 	void OnTriggerEnter(Collider other){
  		if(IsHand(other)){
  			switchBelts();
  		}
	
	}
}
