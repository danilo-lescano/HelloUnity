using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour{

    GameObject player;
    void Start(){
        player = GameObject.FindGameObjectsWithTag("Player")[0];
    }

    void Update(){
        Vector3 direction = (player.transform.position - transform.position).normalized;

        transform.position += direction * Time.deltaTime * 0.5f;
    }

    void OnTriggerEnter2D(Collider2D col){
        if(col.tag == "Bullet")
            Destroy(gameObject);
    }
}