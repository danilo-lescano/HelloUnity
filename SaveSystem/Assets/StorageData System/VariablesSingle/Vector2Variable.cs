using System;
using UnityEngine;
[Serializable]
public class Vector2Variable : IBaseVariable{
    public float val1;
    public float val2;

    public Vector2 value {
        get{
            return new Vector2(val1, val2);
        }
        set{
            val1 = value.x;
            val2 = value.y;
        }
    }
    
}