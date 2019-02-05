using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour{
    public GameObject gb;
    void Update(){
        transform.up = new Vector2(
            Camera.main.ScreenToWorldPoint(Input.mousePosition).x - transform.position.x,
            Camera.main.ScreenToWorldPoint(Input.mousePosition).y - transform.position.y
        );
    }
}
