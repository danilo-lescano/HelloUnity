using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lineRenderer : MonoBehaviour{
    public GameObject obj1, obj2;
    void LateUpdate(){
        if(obj1 != null && obj2 != null){
            Vector3[] pos = {obj1.transform.position, obj2.transform.position};
            GetComponent<LineRenderer>().SetPositions(pos);
        }
    }
}
