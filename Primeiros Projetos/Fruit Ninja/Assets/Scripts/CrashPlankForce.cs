using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashPlankForce : MonoBehaviour{

    Camera cam;
    Rigidbody rb;
    
    void Start(){
        cam = Camera.main;
        rb = GetComponent<Rigidbody>();
        
        Vector3 direction = transform.position - cam.ScreenToWorldPoint(Input.mousePosition);
        rb.AddForceAtPosition(direction.normalized, transform.position * 100f);
    }
}
