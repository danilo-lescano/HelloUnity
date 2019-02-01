using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashPlank : MonoBehaviour{

    Camera cam;
    Rigidbody2D rb;
    
    void Start(){
        cam = Camera.main;
        rb = GetComponent<Rigidbody2D>();
        Vector2 mpos = Input.mousePosition;
        Vector2 direction = rb.position - mpos;
        rb.AddForceAtPosition(direction.normalized, transform.position, ForceMode2D.Force);
    }

    void Update(){
        float leftBoundary, rightBoundary, bottonBoundary;
        rightBoundary = cam.ScreenToWorldPoint(new Vector2(Screen.width, 0)).x;
        leftBoundary = cam.ScreenToWorldPoint(new Vector2(0, 0)).x;
        bottonBoundary = cam.ScreenToWorldPoint(new Vector2(0, 0)).y;

        if(rb.position.x > rightBoundary || rb.position.x < leftBoundary || rb.position.y < bottonBoundary)
            Destroy(gameObject);
    }
}
