using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script12 : MonoBehaviour{
    public float velocity = 10f;
    void Update(){
        if(Input.GetKey(KeyCode.UpArrow))
            transform.Translate(Vector3.forward * velocity * Time.deltaTime);
        if(Input.GetKey(KeyCode.DownArrow))
            transform.Translate(Vector3.forward * velocity * Time.deltaTime * -1f);
        if(Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(Vector3.forward, velocity * Time.deltaTime * -100f);
        if(Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(Vector3.forward, velocity * Time.deltaTime * 100f);
    }
}