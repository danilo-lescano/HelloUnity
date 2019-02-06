using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour{
    public GameObject gb;
    void Update(){
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z += 10;
        transform.position =
            gb.transform.position
            +
            (mousePos - gb.transform.position).normalized * 0.5f;

        transform.up = mousePos - transform.position;
    }
}
