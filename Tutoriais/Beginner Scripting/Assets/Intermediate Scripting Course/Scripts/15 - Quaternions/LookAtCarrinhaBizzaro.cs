using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCarrinhaBizzaro : MonoBehaviour{
    public Transform target;
    void Update(){
        Vector3 pos = target.position;
        pos.y = transform.position.y;
        pos = pos - transform.position;
        transform.rotation = Quaternion.LookRotation(pos, Vector3.up);
        //transform.LookAt(target, Vector3.up);
    }
}