using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour{

    float walkVelocity = 3f;
    float runVelocity = 8f;
    bool firstClick = false;
    bool doubleClick = false;
    float doubleClickTime = 1f;

    void Update(){
        float vel = walkVelocity;

        if((Input.GetKeyDown("left") || Input.GetKeyDown(KeyCode.A)) && !firstClick){
            firstClick = true;
            doubleClick = false;
            doubleClickTime = 1f;
        }
        else if((Input.GetKeyDown("left") || Input.GetKeyDown(KeyCode.A)) && firstClick)
            doubleClick = true;
        if((Input.GetKeyDown("right") || Input.GetKeyDown(KeyCode.D)) && !firstClick){
            firstClick = true;
            doubleClick = false;
            doubleClickTime = 1f;
        }
        else if((Input.GetKeyDown("right") || Input.GetKeyDown(KeyCode.D)) && firstClick)
            doubleClick = true;
        if(firstClick && doubleClickTime > 0)
            doubleClickTime -= Time.deltaTime;
        else
            firstClick = false;

        if(doubleClick)
            vel = runVelocity;


        transform.position = new Vector3(
            transform.position.x
            +
            Input.GetAxis("Horizontal") * Time.deltaTime * vel,
            transform.position.y,
            transform.position.z
        );
    }
}