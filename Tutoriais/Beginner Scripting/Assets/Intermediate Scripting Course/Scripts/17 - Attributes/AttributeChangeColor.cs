using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class AttributeChangeColor : MonoBehaviour{

    [Range(0, 1)]
    public float r = 0, g = 0, b = 0, t = 1;

    void Update(){
        GetComponent<Renderer>().sharedMaterial.color = new Color(r, g, b, t);
    }
}