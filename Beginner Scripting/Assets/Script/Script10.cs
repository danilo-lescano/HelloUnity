using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script10 : MonoBehaviour{
    Light myLight;
    float timeControl = 0f;
    
    void Start(){
        myLight = GetComponent<Light>();
    }

    void Update(){
        timeControl += Time.deltaTime;
        if(timeControl > 1f){
            myLight.enabled = !myLight.enabled;
            timeControl -= 1f;
        }
    }
}