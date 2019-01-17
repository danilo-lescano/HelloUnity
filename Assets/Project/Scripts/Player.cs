using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public GameObject Ball;
	public GameObject PlayerCamera;

	private float BallDistance = 2.5f;
	private float BallThrowingForce = 500f;
	private bool IsHoldingBall = true;

	// Use this for initialization
	void Start () {
		Ball.GetComponent<Rigidbody>().useGravity = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(IsHoldingBall){
			Ball.transform.position = PlayerCamera.transform.position + PlayerCamera.transform.forward * BallDistance;
			if(Input.GetMouseButtonDown(0)){
				IsHoldingBall = false;
				Ball.GetComponent<Rigidbody>().useGravity = true;
				Ball.GetComponent<Rigidbody>().AddForce(PlayerCamera.transform.forward * BallThrowingForce);
			}
		}
	}
}
