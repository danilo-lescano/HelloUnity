using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmControl : MonoBehaviour{
    public GameObject center;
    void Start(){
    }
    void Update(){
        Vector3 centerBodyPos = center.transform.position;
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z += 10;
        transform.position =
            centerBodyPos
            +
            (mousePos - centerBodyPos).normalized * 0.5f;

        transform.up = mousePos - transform.position;
    }
}
