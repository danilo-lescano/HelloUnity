using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour{
    float speed = 3f;
    void Start(){
        //QualitySettings.vSyncCount = 0;
        //Application.targetFrameRate = 10;
    }

    void Update(){
        Vector2 position = transform.position;
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        float rootSquare2 = Mathf.Abs(h) + Mathf.Abs(v) == 2 ? Mathf.Sqrt(2) : 1f;
        position.x += speed * h * Time.deltaTime / rootSquare2;
        position.y += speed * v * Time.deltaTime / rootSquare2;
        transform.position = position;
    }
}