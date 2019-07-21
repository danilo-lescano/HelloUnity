using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using NewNamespace;

public class NoNamespace : MonoBehaviour{
    void Start(){
        print("Estou fora do NewNamespace");
        print(GetComponent<Namespace>().transform.position);
    }
}