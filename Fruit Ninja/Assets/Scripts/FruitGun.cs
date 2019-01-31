using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitGun : MonoBehaviour{

    float second = 0f;

    public GameObject WatermelonPrefab;

    List<GameObject> FruitList = new List<GameObject>();

    Rigidbody2D rb;

    Camera cam;

    void Start(){
        rb = GetComponent<Rigidbody2D>();
        cam = Camera.main;
    }

    void Update(){
        UpdateSecond();

        if(second >= 1f)
            ThrowFruit();
    }
    void UpdateSecond(){
        second += Time.deltaTime;
    }
    void ThrowFruit(){
        float x = Random.Range(0f, Screen.width);
        float y = 0f;
        rb.position = cam.ScreenToWorldPoint(new Vector2(x, y));

        GameObject fruit = Instantiate(WatermelonPrefab, transform);
        FruitList.Add(fruit);

        second = 0f;
    }
    
}
