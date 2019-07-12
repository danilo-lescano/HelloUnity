using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script5 : MonoBehaviour{
    int numberIteration = 3;
    void Start(){
        int i;
        string text = "";

        text += "for loop: ";
        for(i = 0; i < numberIteration; i++)
            text += (i+1) + (i < numberIteration - 1 ? ", " : " ");

        text += "while loop: "; i = 0;
        while(i < numberIteration)
            text += (++i) + (i < numberIteration - 1 ? ", " : " ");

        text += "doWhile loop: "; i = 0;
        do
            text += (++i) + (i < numberIteration - 1 ? ", " : " ");
        while(i < numberIteration);

        text += "foreach loop: ";
        string[] strs = {"1", "2", "3"};
        foreach(string str in strs)
            text += str + (i < numberIteration - 1 ? ", " : " ");

        print(text);
    }
}