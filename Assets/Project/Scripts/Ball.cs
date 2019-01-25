﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	public GameObject trailObject;

	void Start () {
		trailObject.SetActive(false);
	}
	
	public void ActivateTrail() {
		trailObject.SetActive(true);
	}
	public void DeactivateTrail() {
		trailObject.SetActive(false);
	}
}
