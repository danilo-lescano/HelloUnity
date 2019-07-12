using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script3 : MonoBehaviour{
    int teste = 0;
    void Start(){
        int teste = 1;
        print("teste: " + this.teste + "/" + teste);
        {
            print("teste2: " + this.teste + "/" + teste);
        }
    }
}