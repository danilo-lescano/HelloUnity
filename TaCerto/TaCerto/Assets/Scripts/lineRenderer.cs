using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lineRenderer : MonoBehaviour{
    void Update(){
        if(Input.GetMouseButton(0)){
            Vector3 pos =  Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0f));
            pos.z = 0f;
            transform.position = pos;
        }
    }
}
