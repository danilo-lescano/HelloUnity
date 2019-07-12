using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script11 : MonoBehaviour{
    public bool child;

    void Start(){
        string text = "";
        if(!child)
            gameObject.SetActive(false);

        text += "I'm ";
        text += gameObject.activeSelf ? "Activeted." : "not Activeted.";
        text += "\n";
        text += "I'm ";
        text += gameObject.activeInHierarchy ? "Activeted in Hierarchy." : "not Activeted in Hierarchy.";
        print(text);
    }
}