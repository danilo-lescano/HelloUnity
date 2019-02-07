using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour{

    public GameObject player;
    void Start(){

    }

    void Update(){
        Vector3 direction = (player.transform.position - transform.position).normalized;

        transform.position += direction * Time.deltaTime * 0.5f;
    }

    void onCollisionEnter2D(Collision2D col){
        if(col.tag == "bullet"){

        }
    }
}