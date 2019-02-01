using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashPlank : MonoBehaviour{

    Camera cam;
    Rigidbody2D rb;
    Component part1, part2;
    
    void Start(){
        cam = Camera.main;
        rb = GetComponent<Rigidbody2D>();

        part1 = gameObject.transform.GetChild(0);
        part2 = gameObject.transform.GetChild(1);

        Vector2 mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        float size1 = rb.position.x - mousePos.x; if(size1<0) size1 = -size1;
        if(mousePos.x > rb.position.x) size1 += 1.5f;
        part1.transform.localScale = new Vector3(1f, size1, 0.1f) * 0.8f;
        part2.transform.localScale = new Vector3(1f, 3f - size1, 0.1f) * 0.8f;

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
