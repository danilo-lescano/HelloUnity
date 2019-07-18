using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour{
    private static int _point = 0;
    public static int Value {
        get{
            return _point;
        }
        set{
            _point = value;
            
        }
    }

    Text text;
    void Start(){
        text = GetComponent<Text>();
    }

    void Update(){
        text.text = Points.Value + " Points";
    }
}
