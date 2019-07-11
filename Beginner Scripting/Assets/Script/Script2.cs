using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script2 : MonoBehaviour{
    int myInt = 4;
    void Start(){
        int a, b;
        print(myInt);
        (a, b) = MultiplyTwoNumbersByTwo(110, 111);
        print(a + " " + b);
    }

    (int, int) MultiplyTwoNumbersByTwo(int a, int b){
        return (a * 2, b * 2);
    }
}