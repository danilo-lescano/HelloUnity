using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlankGun : MonoBehaviour{

    float second = 0f;

    public GameObject PlankPrefab;

    Rigidbody2D rb;

    Camera cam;

    void Start(){
        rb = GetComponent<Rigidbody2D>();
        cam = Camera.main;
    }

    void Update(){
        UpdateSecond();

        if(second >= 1f)
            ThrowPlank();
    }
    void UpdateSecond(){
        second += Time.deltaTime;
    }
    void ThrowPlank(){
        float x = Random.Range(0f, Screen.width);
        float y = 0f;
        rb.position = cam.ScreenToWorldPoint(new Vector2(x, y));

        GameObject plank = Instantiate(PlankPrefab, transform);
//Quaternion.Euler(new Vector3(0, 0, -90)));
        second = 0f;
    }
    
}
