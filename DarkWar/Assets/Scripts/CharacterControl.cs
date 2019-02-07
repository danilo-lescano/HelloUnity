using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour{

    float walkSpeed = 3f, runSpeed = 8f;
    string lastKeyDown = ""; //last horizontal key pressed
    bool canRun = false;
    float doubleClickTime = 1f; //cont 1 second from the first click to the second
    Rigidbody2D rb;
    int jumpsLeft, maxJumps = 2; //number of consecutives jumps left
    float jumpForce = 300f;

    //clicked key
    void Start(){
        jumpsLeft = maxJumps;
        rb = GetComponent<Rigidbody2D>();
    }

    void Update(){
        CheckDoubleClick();

        UpdatePosition();

        CheckJump();
    }

    void UpdatePosition(){
        float vel = canRun ? runSpeed : walkSpeed;

        transform.position = new Vector3(
            transform.position.x
            +
            Input.GetAxis("Horizontal") * Time.deltaTime * vel,
            transform.position.y,
            transform.position.z
        );
    }

    void CheckDoubleClick(){
        if(Input.GetKeyDown("left") || Input.GetKeyDown(KeyCode.A)){
            if(lastKeyDown == "left" && doubleClickTime > 0f)
                canRun = true;
            
            lastKeyDown = "left";
            doubleClickTime = 1f;
        }
        else if(Input.GetKeyDown("right") || Input.GetKeyDown(KeyCode.D)){
            if(lastKeyDown == "right" && doubleClickTime > 0f)
                canRun = true;
            
            lastKeyDown = "right";
            doubleClickTime = 1f;
        }
        else if(doubleClickTime > 0f)
            doubleClickTime -= Time.deltaTime;
        else if(Input.GetAxis("Horizontal") == 0)
            canRun = false;
    }

    void CheckJump(){
        if(Input.GetKeyDown(KeyCode.Space) && jumpsLeft > 0){
            jumpsLeft--;
            rb.AddForce(new Vector2(0f, jumpForce));
        }
    }

    void OnTriggerEnter2D(Collider2D col){
        if(col.tag == "Floor")
            jumpsLeft = maxJumps;
    }
}