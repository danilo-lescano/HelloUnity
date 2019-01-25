using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public Ball ball;
	public GameObject PlayerCamera;

	private float BallDistance = 2.5f;
	private float BallThrowingForce = 500f;
	private bool IsHoldingBall = true;

	// Use this for initialization
	void Start () {
		ball.GetComponent<Rigidbody>().useGravity = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(IsHoldingBall){
			ball.transform.position = PlayerCamera.transform.position + PlayerCamera.transform.forward * BallDistance;
			if(Input.GetMouseButtonDown(0)){
				IsHoldingBall = false;
				ball.ActivateTrail();
				ball.GetComponent<Rigidbody>().useGravity = true;
				ball.GetComponent<Rigidbody>().AddForce(PlayerCamera.transform.forward * BallThrowingForce);
			}
		}
		else{
			if(Input.GetMouseButtonDown(0)){
				IsHoldingBall = true;
				ball.DeactivateTrail();
				ball.GetComponent<Rigidbody>().useGravity = false;
				ball.GetComponent<Rigidbody>().velocity = Vector3.zero;
			}
		}
	}
}
