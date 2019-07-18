using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script18 : MonoBehaviour{
    void OnMouseDown(){
        GetComponent<Rigidbody>().AddForce(-transform.forward * 500f);
        GetComponent<Rigidbody>().useGravity = true;
    }
}