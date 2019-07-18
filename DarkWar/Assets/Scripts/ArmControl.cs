using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmControl : MonoBehaviour{
    GameObject bulletPrefab;

    void Start(){
        bulletPrefab = (GameObject) Resources.Load("Prefab/Bullet");
        if(bulletPrefab == null)
            Debug.Log("hehe");
    }
    public GameObject center;
    void Update(){
        ChangeDirection();

        if(Input.GetMouseButtonDown(0))
            Shoot(transform.up);
    }
    void Shoot(Vector3 direction){
        GameObject ob = Instantiate(bulletPrefab);
        ob.transform.position = transform.position;
        Bullet b = ob.GetComponent<Bullet>();
        b.Direction = direction.normalized;
    }
    void ChangeDirection(){
        Vector3 centerBodyPos = center.transform.position;
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z += 10; //offset
        Vector3 direction = (mousePos - centerBodyPos).normalized;
        transform.position =
            centerBodyPos
            +
            direction * 0.5f;

        transform.up = mousePos - transform.position;
    }
}