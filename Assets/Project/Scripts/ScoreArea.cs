using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreArea : MonoBehaviour {

	public GameObject effectObject;
	private float timer = 0f;

	void Start(){
		effectObject.SetActive(false);
	}

	void Update(){
		timer -= Time.deltaTime;
		if(effectObject.active && timer < 0) 
			effectObject.SetActive(false);
	}

	void OnTriggerEnter(Collider otherCollider){
		if(otherCollider.GetComponent<Ball>() != null){
			effectObject.SetActive(true);
			timer = 1f;
		}
	}
}
