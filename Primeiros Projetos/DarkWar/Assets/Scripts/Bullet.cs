using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour{
    public Vector3 Direction { get; set; } = new Vector3(0f, 0f, 0f);

    void Update(){
        transform.position += Direction * 0.3f;
    }

    void OnTriggerEnter2D(Collider2D col){
        if(col.tag == "Enemy" || col.tag == "Floor")
            Destroy(gameObject);
    }
}