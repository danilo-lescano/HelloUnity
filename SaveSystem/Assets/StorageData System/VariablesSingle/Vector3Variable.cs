using System;
using UnityEngine;
[Serializable]
public class Vector3Variable : IBaseVariable{
    public float val1;
    public float val2;
    public float val3;

    public Vector3 value {
        get{
            return new Vector3(val1, val2, val3);
        }
        set{
            val1 = value.x;
            val2 = value.y;
            val3 = value.z;
        }
    }
    
}