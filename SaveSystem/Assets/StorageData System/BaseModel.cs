using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class BaseModel : IBaseModel{
    public List<IBaseVariable> ListValue { get; set; }
}