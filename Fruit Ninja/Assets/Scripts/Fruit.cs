﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour{

    Camera cam;
    Rigidbody2D rb;
    void Start(){
        float xForce = Random.Range(0f, 250f);
        float yForce = Random.Range(500f, 750f);

        cam = Camera.main;
        rb = GetComponent<Rigidbody2D>();

        float screenMiddle = cam.ScreenToWorldPoint(new Vector2(Screen.width/2, 0)).x;

        if(rb.position.x > screenMiddle)
            xForce = -xForce ;

        rb.AddForce(new Vector2(xForce, yForce));
    }

    void Update(){
        float leftBoundary, rightBoundary, bottonBoundary;
        rightBoundary = cam.ScreenToWorldPoint(new Vector2(Screen.width, 0)).x;
        leftBoundary = cam.ScreenToWorldPoint(new Vector2(0, 0)).x;
        bottonBoundary = cam.ScreenToWorldPoint(new Vector2(0, 0)).y;

        if(rb.position.x > rightBoundary || rb.position.x < leftBoundary || rb.position.y < bottonBoundary)
            Destroy(gameObject);
        
    }

    void OnTriggerEnter2D(Collider2D col){
        if(col.tag == "Blade")
            Destroy(gameObject);
    }
}
