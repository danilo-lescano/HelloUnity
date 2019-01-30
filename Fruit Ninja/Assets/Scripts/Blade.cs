using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blade : MonoBehaviour{

    CircleCollider2D cc;
    Rigidbody2D rb;
    Camera cam;
    float minVelocity = 0.001f;
    public GameObject BladeTrailPrefab;
    GameObject BladeTrail;
    bool isDragin = false;
    void Start(){
        rb = GetComponent<Rigidbody2D>();
        cc = GetComponent<CircleCollider2D>();
        cc.enabled = false;
        cam = Camera.main;
    }

    void Update(){
        UpdatePosition();

        if(Input.GetMouseButtonDown(0))
            RenderTrail();
        else if(Input.GetMouseButtonUp(0))
            RemoveTrail();
    }
    void UpdatePosition(){
        Vector2 prevPos = rb.position;
        Vector2 newPos = rb.position = cam.ScreenToWorldPoint(Input.mousePosition);
        float velocity = (newPos - prevPos).magnitude * Time.deltaTime;
        
        if(isDragin && velocity >= minVelocity)
            cc.enabled = true;
        else
            cc.enabled = false;
    }
    void RenderTrail(){
        UpdatePosition();
        BladeTrail = Instantiate(BladeTrailPrefab, transform);
        isDragin = true;
    }
    void RemoveTrail(){
        BladeTrail.transform.SetParent(null);
        isDragin = false;
    }
}
