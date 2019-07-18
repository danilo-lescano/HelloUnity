using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script7 : MonoBehaviour{
    public string myName;
    void Awake(){
        print(myName + " awake");
    }

    void Start(){
        print(myName + " start");
    }
}