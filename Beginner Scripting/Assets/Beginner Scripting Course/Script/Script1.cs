using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script1 : MonoBehaviour{
    void Update(){
        Color color = Color.black;
        if(Input.GetKey(KeyCode.R))
            color.r = 1f;
        if(Input.GetKey(KeyCode.G))
            color.g = 1f;
        if(Input.GetKey(KeyCode.B))
            color.b = 1f;

        if(color != Color.black)
            GetComponent<Renderer>().material.color = color;
    }
}