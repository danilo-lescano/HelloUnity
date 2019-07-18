using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script13 : MonoBehaviour{
    public bool isAlvo;
    public GameObject alvo;
    void Update(){
        if(isAlvo)
            transform.Translate(Vector3.forward * Time.deltaTime);
        else
            transform.LookAt(alvo.transform);
    }
}